using Microsoft.Extensions.DependencyInjection;
using System;

namespace DNLiCore_DI
{
    public class ServiceContext
    {
        private static IServiceProvider _serviceProvider = null;
        private static IServiceCollection _iserviceCollection = null;
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            _iserviceCollection = serviceCollection;
            _serviceProvider = serviceCollection.BuildServiceProvider();  //根容器
        }


        /// <summary>
        /// 获取指定注册服务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            if (_serviceProvider != null)
            {
                return _serviceProvider.GetService<T>();
            }
            else
            {
                return default(T);
            }
        }

       

    }
}
