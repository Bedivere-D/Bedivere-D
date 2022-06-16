using System;
using Kingdee.BOS;
using Kingdee.BOS.Util;
using System.ComponentModel;

namespace Killy.K3.Demo.Constracts
{
    [Description("服务工厂"), HotUpdate]
    public class ServiceFactory
    {
        public static ServicesContainer _mapServer = new ServicesContainer();

        static bool noRegistered = true;

        static ServiceFactory()
        {
            RegisterService();
        }

        public static T GetService<T>(Context ctx)
        {
            return GetService<T>(ctx, ctx.ServerUrl);
        }

        /// <summary>
        /// 获及服务实例
        /// </summary>
        /// <typeparam name="T">服务接口类型</typeparam>
        /// <param name="ctx">上下文</param>
        /// <param name="url">服务实例</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        static T GetService<T>(Context ctx, string url)
        {
            if (ctx == null)
            {
                throw new Exception("{ctx == null}");
            }
            if (noRegistered)
            {
                RegisterService();
            }
            var instance = _mapServer.GetService<T>(typeof(T), url);
            if (instance == null)
            {
                throw new Exception("获取服务对象失败，请检查己映射该对象!");
            }
            return instance;
        }

        /// <summary>
        /// 增加对应的接口与实现类的对应关系
        /// </summary>
        public static void RegisterService()
        {
            if (!noRegistered) return;
            _mapServer.Add(typeof(ISaleService), "Killy.K3.Demo.App.Core.SaleService,Killy.K3.Demo.App.Core");
            noRegistered = false;
        }

        /// <summary>
        /// 关闭服务实例
        /// </summary>
        /// <param name="service"></param>
        public static void CloseService(object service)
        {
            IDisposable disposable = service as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}
