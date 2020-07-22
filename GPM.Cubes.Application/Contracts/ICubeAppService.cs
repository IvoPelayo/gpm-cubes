﻿using GPM.Cubes.Application.Dtos;

namespace GPM.Cubes.Application.Contracts
{
    public interface ICubeAppService
    {
        bool HaveCollision(CubeCoordinates cube, CubeCoordinates cube2);

        float GetIntersection(CubeCoordinates cube1, CubeCoordinates cube2);
    }
}