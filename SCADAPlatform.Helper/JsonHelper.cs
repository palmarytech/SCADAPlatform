using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace SCADAPlatform.Helper
{
    public class JsonHelper
    {
        /// <summary>
        /// 将对象序列化为 JSON 并保存到指定文件路径
        /// </summary>
        /// <typeparam name="T">要序列化的对象类型</typeparam>
        /// <param name="filePath">完整的文件路径（如 @"C:\data\config.json"）</param>
        /// <param name="obj">要序列化的对象</param>
        /// <param name="formatted">是否格式化输出（美化 JSON，方便阅读），默认为 false</param>
        /// <returns>序列化是否成功</returns>
        public static bool SerializeObject<T>(string filePath, T obj, bool formatted = false)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("文件路径不能为空", nameof(filePath));

            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            try
            {
                // 设置序列化选项
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Formatting = formatted ? Formatting.Indented : Formatting.None,
                    NullValueHandling = NullValueHandling.Ignore,     // 忽略 null 值，文件更干净
                    DefaultValueHandling = DefaultValueHandling.Include, // 忽略默认值（如 int=0, string=""）
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore // 防止循环引用导致异常
                };

                // 序列化为 JSON 字符串
                string json = JsonConvert.SerializeObject(obj, settings);

                // 确保目录存在
                string directory = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // 写入文件（使用 UTF-8 无 BOM 编码更标准）
                File.WriteAllText(filePath, json, new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

                return true;
            }
            catch (Exception ex)
            {
                // 建议记录日志，而不是直接 throw（调用者可决定是否捕获）
                // UserLog.AddExceptionMsg(ex);  // 如果你有日志系统
                // throw; // 如果想让调用者知道失败，可选择 throw
                Console.WriteLine($"序列化失败: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 重载：默认不格式化
        /// </summary>
        public static bool SerializeObject<T>(string filePath, T obj)
        {
            return SerializeObject(filePath, obj, formatted: false);
        }

        /// <summary>
        /// 从指定文件中反序列化 JSON 为指定类型的对象
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="filePath">完整的 JSON 文件路径</param>
        /// <returns>反序列化后的对象，如果失败返回 default(T)</returns>
        public static T DeserializeObject<T>(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("文件路径不能为空", nameof(filePath));

            if (!File.Exists(filePath))
            {
                // 文件不存在时返回默认值（常见处理方式），也可抛异常看项目需求
                // throw new FileNotFoundException("序列化文件不存在", filePath);
                return default(T);
            }

            try
            {
                // 读取文件内容（使用 UTF-8 编码）
                string json = File.ReadAllText(filePath, System.Text.Encoding.UTF8);

                // 如果内容为空或空白，返回默认值
                if (string.IsNullOrWhiteSpace(json))
                    return default(T);

                // 配置反序列化设置
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,     // 忽略 JSON 中不存在的字段（版本兼容）
                    DefaultValueHandling = DefaultValueHandling.Include,     // 用 JSON 值覆盖默认值
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,     // 防止循环引用异常
                                                                              // TypeNameHandling = TypeNameHandling.Auto,              // 如需多态支持可打开（注意安全风险）
                    Error = (sender, args) =>
                    {
                        // 可选：记录反序列化错误但不中断（继续尝试其他字段）
                        args.ErrorContext.Handled = true;
                    }
                };

                T result = JsonConvert.DeserializeObject<T>(json, settings);

                return result;
            }
            catch (JsonException jsonEx)
            {
                // JSON 格式错误，最常见的反序列化失败原因
                Console.WriteLine($"JSON 反序列化失败（格式错误）：{jsonEx.Message} 文件: {filePath}");
                // UserLog.AddExceptionMsg(jsonEx); // 如果你有日志系统
                return default(T);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"反序列化失败：{ex.Message} 文件: {filePath}");
                // UserLog.AddExceptionMsg(ex);
                return default(T);
            }
        }

        /// <summary>
        /// 重载：直接从 JSON 字符串反序列化（不读文件）
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="json">JSON 字符串</param>
        /// <returns>反序列化后的对象，失败返回 default(T)</returns>
        public static T DeserializeFromString<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return default(T);

            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"从字符串反序列化失败：{ex.Message}");
                return default(T);
            }
        }
    }
}
