using Prism.Ioc;
using System;
using System.Linq;
using System.Reflection;

namespace BookShelves.Infra
{
    public sealed class Bootstrapper
    {
        private static IContainerRegistry ContainerRegistry;

        public static void InitIOCContainer<T>(IContainerRegistry containerRegistry)
        {
            ContainerRegistry = containerRegistry;
            RegisterModules(typeof(T));
        }

        public static void RegisterModules(Type type) => RegisterApplicationPagesForNavigation(type);

        private static void RegisterApplicationPagesForNavigation(Type type)
        {
            ContainerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>();

            foreach (var item in type.GetTypeInfo().Assembly.DefinedTypes.Where(t => t.GetCustomAttributes<PageAttribute>() != null))
                ContainerRegistry.RegisterForNavigation(item.AsType(), item.AsType().Name);
        }
    }
}
