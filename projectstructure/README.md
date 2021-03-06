# Project Structure

When looking at official.NET Core and ASP.NET Core repositories you will find a common convention in the layout of the repository. It is a good practise to also create your repository using a similar structure as it makes it easier for others to understand it.

```
.
|-- src\<project x>
|-- tests\<project x>.tests
|-- docs\
|-- tools\
|-- samples\
|-- <repo>.sln

```

* ```src``` is the folder where you place all of the projects that makes up the solution.
* ```tests``` is the folder where you place all of the test projects, ideally every project in the source folder should have a corresponding test project. The convention is that each test project should have the same project name as the corresponding source project but with the post fix of .tests.
* ```docs``` document the repsitory, see [Documenting your projects on GitHub](https://guides.github.com/features/wikis/)
* ```tools``` a folder containing shell scripts, tools etc that makes the development easier. See [DotNet Tools](https://github.com/natemcmaster/dotnet-tools) for an extensive list of dotnet utilities. See [Entity Framework tools](https://github.com/aspnet/EntityFrameworkCore/tree/release/2.2/tools) for useful scripts managing databases.
* ```samples``` a folder with sample of how to use this repository, normally used if you are building an api or libraries.


