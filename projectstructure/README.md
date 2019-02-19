# Project Structure

When looking at official.NET Core and ASP.NET Core repositories you will find a common convention in the layout of the repository.

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
* ```tests``` is the folder where you place all of the test projects, ideally every project in the source folder should have a corresponding test project. Each test project should have the same project name as the corresponding source project but withj the post fix of .tests.
* ```docs``` document the repsitory, see [ Documenting your projects on GitHub](https://guides.github.com/features/wikis/)
* ```tools``` a folder containing shell scripts, tools etc that makes the development easier.
* ```samples``` a folder with samjple projects, usually only reaaly used if you are building an api or library.


