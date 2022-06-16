using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killy.K3.Demo.Core
{
    public class LogHelper
    {
        /// <summary>
        /// 写结果日志
        /// </summary>
        /// <param name="method">执行函数</param>
        /// <param name="request">请求内容</param>
        /// <param name="result">执行结果</param>
        public static void WriteLog(string method, string request, string result)
        {
            try
            {
                Task.Run(() =>
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Log" + DateTime.Now.ToString("yyyyMM"));
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    string fileName = method + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                    string fileFullPath = Path.Combine(path, fileName);
                    using (var sw = File.AppendText(fileFullPath))
                    {
                        sw.WriteLine("------------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "------------\r\n");
                        sw.WriteLine(request);
                        sw.WriteLine(result);
                        sw.WriteLine("------------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "------------\r\n");
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
