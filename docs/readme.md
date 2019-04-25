# Create a new project

Although not all of these steps are required, they are useful.

* Run `git init <projectname>` to create a working directory with a git repository

* Go into the folder by typting in `cd <projectname>`

* Run `dotnet --list-sdks` to check what versions of dotnet core you have installed on your machine.

* Run `dotnet new global` to create a **global.json** file that you can 

* Run `dotnet new webapi` to create a new webapi project

# Add a **.gitignore** file

```
https://raw.githubusercontent.com/dotnet/core/master/.gitignore
```

* Run the base project by typing in `dotnet run` and view your site by going to [http://localhost:5000/api/values](http://localhost:5000/api/values)

* Do an initial commit to yoru repository `git add .` && `git commit -m "Initial Commit"`

> Hint: Making regular commits allows you to revert back to previous version of your code if you make an error :-)

---

Download SQL Server based on ubuntu

```
docker pull mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
```

Run your database on your machine

```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
```