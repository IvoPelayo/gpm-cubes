using AutoMapper;

namespace GPM.Cubes.Application.Mapping
{
    public class AutoMapperConfiguration
    {
        public static IMapper GetMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AddProfile<DtoToEntitiesProfile>();
            });

            configuration.CompileMappings();
            return configuration.CreateMapper();
        }
    }
}