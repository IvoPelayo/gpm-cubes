using AutoMapper;
using GPM.Cubes.Application.Dtos;
using GPM.Cubes.Domain.Entities;
using GPM.Cubes.Domain.Factories;

namespace GPM.Cubes.Application.MappingProfiles
{
    public class DtoToEntitiesProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DtoToDomainMappings";
            }
        }

        public DtoToEntitiesProfile()
        {
            CreateMap<CubeCoordinates, Cube>()
                .ConstructUsing((coord) =>
                    CubeFactory.Cube()
                    .WithCenterCoordinates(coord.X, coord.Y, coord.Z)
                    .WithDimension(coord.Dimension)
                    .Build()
                );
        }
    }
}