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

        public float GetIntersection(CubeCoordinates coordinates1, CubeCoordinates coordinates2)
        {
            var cube1 = _mapper.Map<CubeCoordinates, Cube>(coordinates1);
            var cube2 = _mapper.Map<CubeCoordinates, Cube>(coordinates2);

            return 0;
        }

        public bool HaveCollision(CubeCoordinates cube, CubeCoordinates cube2)
        {
            throw new System.NotImplementedException();
        }
    }
}