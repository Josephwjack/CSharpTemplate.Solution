# Factory (AKA Dr SillyStringz's factory)

#### By _**Joseph Jack**_  

#### _This website allow the user to add engineers and machines to the factory database. Engineers and machines can both be assigned to multiple other entries or none at all. The application also allows the user to edit and delete any entries which will apply to the local database._

---


## Technologies Used

* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
* [.NET](https://dotnet.microsoft.com/en-us/)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [SQL Workbench](https://www.mysql.com/products/workbench/)
* [MVC](https://developer.mozilla.org/en-US/docs/Glossary/MVC)
* [HTML](https://en.wikipedia.org/wiki/HTML)
* [CSS](https://www.w3schools.com/css/)


---
## Setup and Installation Requirements
This Setup assumes you have GitBash and MySQL Workbench pre-installed. 
<br><small>If you do not have one or both installed, please begin with that setup below. 
<br>If you _do_ have both installed, move onto "initial setup".</small>

<details>
<summary><strong>GitBash and MySQL Workbench Setup</strong></summary>
<ol>
<li>https://git-scm.com/download/  
<li>Download Git and follow the setup wizard. 
<li>https://dev.mysql.com/downloads/workbench/     
<li>Download MySQL Workbench
<li>Follow the setup wizard & create a localhost server on port 3306.
<li>Keep track of your username and password, this will be used in the connection steps of "**SQL Workbench Configuration**"  
</details>
<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/Josephwjack/Factory.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/Josephwjack/Factory.Solution</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "Factory.Solution".
<li>Navigate to the projects root directory, "Factory".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "Factory" directory  
   <pre>Factory.Solution
   └── Factory
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "Factory", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "factory" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>restaurants</strong>, <strong>recipes</strong>, <strong>ingredients</strong>, <strong>reciperestaurant</strong>, & <strong>ingredientrecipe</strong>.
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>Factory.Solution
   └── <strong>Factory</strong></pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.

---
## Known Bugs

* _No known issues_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 8/5/2022 Joseph Jack
