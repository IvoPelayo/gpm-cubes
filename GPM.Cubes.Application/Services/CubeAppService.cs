using AutoMapper;
using GPM.Cubes.Application.Contracts;
using GPM.Cubes.Application.Dtos;
using GPM.Cubes.Domain.Entities;

namespace GPM.Cubes.Application.Services
{
    public class CubeAppService : ICubeAppService
    {
        private readonly IMapper _mapper;

        public CubeAppService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public double GetIntersection(CubeCoordinates firstCubeCoordinates, CubeCoordinates secondCubeCoordinates)
        {
            var firstCube = _mapper.Map<CubeCoordinates, Cube>(firstCubeCoordinates);
            var secondCube = _mapper.Map<CubeCoordinates, Cube>(secondCubeCoordinates);

            return firstCube.Intersection(secondCube);
        }

        public bool HaveCollision(CubeCoordinates firstCubeCoordinates, CubeCoordinates secondCubeCoordinates)
        {
            var firstCube = _mapper.Map<CubeCoordinates, Cube>(firstCubeCoordinates);
            var secondCube = _mapper.Map<CubeCoordinates, Cube>(secondCubeCoordinates);

            return firstCube.Collides(secondCube);
        }
    }
}