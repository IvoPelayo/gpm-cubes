# Cubes excersise

This is a simple project to show my skills as a C# .NET Developer. Requirement:

Design and start and application (or test project) which accepts as input dimensions and coordinates of two cubic objects (considering a 3D space).
The application must determine whether the two objects collide and calculate the intersected volume.
It's not a math exercise, so it is acceptable to consider the two cubes are parallel, so there is no rotation among themselves.
The input coordinates define the center of the cube.
The purpose of this exercise is to define the application design and architecture, focusing on the parts which ensure the correctness, performance and code clarity. Any design pattern is accepted and should be justified.

### Notes

- You can check the [commit history](https://github.com/IvoPelayo/gpm-cubes/commits/master) to see the development sequence of the solution.

- Since this is a simple excersise doesn't have too much layer complexity, only Application & Domain are part of the solution (no infrastructure, adapters, or top level layers whatsoever).

- This serves as a Core, while multiple top level layers could have access to this features. An example of DI pattern implementation is on [TestConfigurator](GPM.Cubes.IntegrationTest/TestConfigurator.cs) class.

### Prerequisites

To run this solution locally you will need:
- Visual Studio 2017

### Test

This solution has Unit and Integration Test, both runeable from the VS TestExplorer window.

## License
[MIT](https://choosealicense.com/licenses/mit/)
