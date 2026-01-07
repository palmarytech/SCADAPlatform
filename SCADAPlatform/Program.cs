using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace SCADAPlatform
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ===== 第1步：确保日志目录存在=====
            string logDirectory = Path.Combine(Application.StartupPath, "Logs");
            if (!Directory.Exists(logDirectory))
            {
                try
                {
                    Directory.CreateDirectory(logDirectory);
                }
                catch (Exception ex)
                {
                    // 如果连目录都创建失败（权限问题等），弹出提示并退出
                    MessageBox.Show($"无法创建日志目录：{logDirectory}\n错误：{ex.Message}",
                        "日志初始化失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 直接退出程序
                }
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()  // 最低级别，可改 Information
                .Enrich.WithThreadId()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .WriteTo.Console()  // 调试时输出到控制台
                .WriteTo.Debug()    // 输出到 Visual Studio 输出窗口
                .WriteTo.File(
                    path: Path.Combine(Application.StartupPath, "Logs", "log-.txt"),  // 日志文件夹
                    rollingInterval: RollingInterval.Day,    // 每天一个文件
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: 10 * 1024 * 1024,    // 单文件最大10MB
                    retainedFileCountLimit: 30,             // 保留30天日志
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] (Thread:{ThreadId}) {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();
            try
            {
                Log.Information("=== 程序启动 ===");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "程序发生未处理的异常，应用即将退出");
                MessageBox.Show("程序发生严重错误，即将退出。", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("=== 程序退出 ===");
                Log.CloseAndFlush();  // 确保所有日志写入磁盘
            }

        }
    }
}
