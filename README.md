# Livy Webservice

This is a simple project to show my skills as a C# .NET Developer. You can take a look at the requirements for this excercise [here](Assessment_back-end_(Senior)_v1.0.pdf)

## Getting Started

This is a public repo, so feel free to clone it and take a look at the solution.

### Prerequisites

To run this solution locally you will need:
- Visual Studio 2017 or above
- Nuget
- IIS
- Windows powershell (optional)
- Postman (to run examples)

### Build

If you have experience with Visual Studio you could simply start the project and visit http://localhost:1487

If you want a local instance of the site without Visual Studio running, use the Setup script located on the Tools/Setup folder:

- run Windows Powershell as Administrator
- navigate to directory Tools/Setup
- run:

```
... Tools/Setup> ./Setup.ps1 *path-to-solution* *msbuild-exe-path(optional)*
```
- web service will be available at http://localhost:1800

### Test

You can find a full list of examples [here](Livy-Examples.postman_collection)
Import this collection to postman and start testing! You can find more information about every call on the description that each one provides


Note: to simplify the api calls it always use an admin user accessToken. methods on the policies controller are bloqued to users without that role

## License
[MIT](https://choosealicense.com/licenses/mit/)
