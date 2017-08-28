# Mr Fix-It
##### A repair technician job service.
This project was build by the faculty of *_Epicodus_* and finished by *_Hunter Parks_*

***
### Description
This project is to show my understanding of .NET and jQuery by taking a project already completed and reformat and finish the project with ease.

The front of this project is a crowd-source repair company called **Mr.Fix-it**. Users post jobs on the forum and accept job offers for paid-tasks, essentially an **Angies-list** clone.

***
### Instructions
* [Clone the Repository](https://github.com/HunterTParks/MrFixIt-dotnet)
* In VS (Visual Studio) / Atom, open the project and navigate to *_AppSettings.json_*
* Make sure the file has the following ...
```javascript
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=MrFixIt;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
* Navigate to the Models folder and open the *_MrFixItContext_* and make sure it has the following code...
```javascript
options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MrFixIt;integrated security=True");
```

* Run the following command
```console
$ dotnet ef database update
```
* Now you are able to run the application. Run the following command
```console
$ dotnet run
```

***
### Tasks Completed | Tasks In progress | Tasks to do
##### Completed
* Users can register and log on
* Users may sign up to be "workers" on the site.
* New jobs may be added to the jobs list.
* A job can be assigned to a worker.
* A worker may take on mulitple jobs from the Worker Dashboard.
* Make *claiming* a job an **AJAX** action.
* A worker may designate one **active** job at a time. **AJAX**
* Workers may mark jobs complete, and select a new active job. **AJAX**

##### In Progress
* None

##### To do
* None

***

### Dependencies Used
* HTML
* JQUERY
* BOOTSTRAP
* C#
* ASP.NET CORE

***

### Known Bugs
There are no known bugs at this time

***

### Support
If you would like to contact me or report a bug, Please email me at hunter.thomas.parks@gmail.com

***

### Copyright
Copyright 2017 *_Hunter Parks_*

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
