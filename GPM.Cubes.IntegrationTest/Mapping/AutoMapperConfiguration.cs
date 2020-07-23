using AutoMapper;
using GPM.Cubes.Application.MappingProfiles;

namespace GPM.Cubes.IntegrationTest.Mapping
{
    internal class AutoMapperConfiguration
    {
        public static IMapper GetMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AddProfile<DtoToEntitiesProfile>();
            });

            configuration.CompileMappings();
            configuration.AssertConfigurationIsValid();

            return configuration.CreateMapper();
        }
    }
}