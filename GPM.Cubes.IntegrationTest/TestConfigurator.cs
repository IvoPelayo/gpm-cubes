using Autofac;
using GPM.Cubes.Application.Contracts;
using GPM.Cubes.Application.Mapping;
using GPM.Cubes.Application.Services;

namespace GPM.Cubes.IntegrationTest
{
    internal class TestConfigurator
    {
        public static IContainer container;

        public TestConfigurator()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CubeAppService>()
                .As<ICubeAppService>()
                .InstancePerLifetimeScope();

            builder.RegisterInstance(AutoMapperConfiguration.GetMapper()).SingleInstance();

            container = builder.Build();
        }

        public T GetInstance<T>()
        {
            return container.Resolve<T>();
        }
    }
}