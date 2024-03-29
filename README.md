# Task Tracker

<div style="text-align: center;">
  <img src="https://github.com/urltapas/task-tracker/assets/99461398/f8a9483a-bf72-463d-b1a7-e36bdc475cd5" style="width: 71%; display: inline-block;">
  <img  src="https://github.com/urltapas/task-tracker/assets/99461398/07201c61-b581-49c6-81c6-75a9e5e0abd0" alt="Descrição da primeira imagem" style="width: 28%; display: inline-block;">
</div>


# Task Tracker

## 📖 About

Task Tracker is an application designed to enhance the tracking of  activities within an organization. Leveraging .NET 8, Supabase(Postgres), and Entity Framework Core, the project provides a platform for efficient management and monitoring of tasks.

## 🧱 This project was built with:

- [.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
- [Supabase](https://supabase.com/)
- [Entity Framework Core](https://github.com/dotnet/efcore)
- [RestShap](https://restsharp.dev/)

## 🚶‍♂️ Installing and Running

1. Create an account on [Supabase](https://supabase.com/dashboard/sign-in?returnTo=%2Fprojects) and start a new project
2. From the supabase website, get the connection string for .NET
3. Clone this repository `git clone https://github.com/urltapas/task-tracker`
4. Enter in the project's folder: `cd task-tracker`
5. Run `dotnet restore`

> If you haven't downloaded .NET yet you can follow this tutorial [Install .NET on Windows, Linux, and macOS](https://learn.microsoft.com/en-us/dotnet/core/install/)

6. Guarantee that you have Entity Framework Core installed globally `dotnet tool install --global dotnet-ef`

> If you are using Linux, maybe you will need to add the dotnet-ef to your path.
> Like this:
>
> ```bash
> sudo nano .bashrc # or sudo nano .zshrc
> # Append this to the bottom of the file
> export PATH="$PATH:$HOME/.dotnet/tools/"
> ```

7. If this is your first time running the project, follow these steps:
   1. Execute `./application-helper.ps1` and select the option `3. Update Database`
   2. Select `4. Manage` User Secrets and add the SQL connection string to the user secret settings for both the TaskTracker Console and TaskTracker API applications using the key `ConnectionStrings:SqlConnection`.

> If you are using Linux, you can run the script using the PowerShell Core. [Install PowerShell on Linux](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-linux?view=powershell-7.4)5.  Run the API with

```bash
dotnet run --project ./src/TaskTracker.Api
```

1. Run the console app with

```bash
dotnet run --project ./src/TaskTracker.Console
```

## ♻ Contribute

Fork this repository

Create a branch with your feature: `git checkout -b my-feature`

Commit your changes: `git commit -m 'feat: My new feature'`

Push your branch: `git push origin my-feature`

## 📃 License

This project is under the MIT license. Take a look at the [LICENSE](LICENSE) file for more details.
