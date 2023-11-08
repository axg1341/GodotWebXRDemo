# Setting up a Dotnet Application to serve WebXR

### Intall Necessary Dependencies
- To create a dotnet project, you will need the dotnet SDK. You can get the latest version [here](https://dotnet.microsoft.com/en-us/download)
- Once you have installed the dotnet sdk, add it to path and test out a dot net command in your terminal to ensure that is correctly placed within your path. You can type `dotnet --version`.
- It is optional, however, reccomended that you have [Visual Studio](https://visualstudio.microsoft.com/#vs-section) or [Visual Studio Code](https://visualstudio.microsoft.com/#vscode-section) as an IDE to edit your code.

### Creating the ASP Web Framework
Dotnet has various templates that can be used for creating a website. For our purpose, we will create a static webpage. If you do intend on using a database or models, you will likely go with an [MVC](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc) template.

1. Navigate to where you want to start your project. Ensure that you have all of the project files that were built from your webxr project.
2. Once are in the directory where you want to start the asp.net project, type the command `dotnet new webapp -o Name_of_your_project`. Replace the name of your project with a descriptive name of your choosing.
3. You should now have a file structure that looks like this:


