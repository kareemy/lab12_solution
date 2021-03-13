## Your Name:


# CIDM 3312 Lab 11: ASP.NET Core + EF Core Professor App

In this lab exercise you will perform the 8 steps to create an ASP.NET Core app with EF Core. Your app will hard-code professor names in an EF Core database and display those names in a Razor Page. You will also use a SelectList to allow the user to select a specific professor.

## Step 1: Create an ASP.NET Core Project

1. Create an ASP.NET Core Project using the `dotnet new webapp` command.

## Step 2: Bring in EF Core Packages

1.	Add EF Core to the project:

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Step 3: Create the Complete EF Core Data Model

1.	Create a new folder called `Models`
2.	Inside the Models folder, create a new file called `Professor.cs`. This is an Entity Class.
      * Each professor should have an ID, First Name, and Last Name
3.	Inside the Models folder, create a new file called `ProfessorContext.cs`
      * This is the EF Core Database Context Class. Review the examples from slides and code.

## Step 4: Configure database settings in `appsettings.json`

1.	Write the proper configuration in the appsettings.json file.

## Step 5: Dependency Injection Part 1

1.	Register your database context as a service using dependency injection
2.	**PAUSE**. Run dotnet build now at the terminal. If you see build errors, debug!

## Step 6: Migrations

1.	Perform the initial migrations at the terminal.

## Step 7: Seed Data

1.	Inside the `Models` folder, create a new file called `SeedData.cs`
2.	Write the code to create the `SeedData` class. Make at least 3 professors.
3.	Within `Main()`, write the code to call your `SeedData.Initialize()` method.
4.	**PAUSE**. Run dotnet build now at the terminal. If you see build errors, debug!

## Step 8: Combine ASP.NET Core + EF Core

1.	List all the professors on the `Index.cshtml` Razor Page such that each professor (FirstName + LastName) is displayed on their own line in the web page.
2.	You need to do the following:
      * Bring the DbContext into the `IndexModel` class via Dependency Injection.
      * Use LINQ to create a list of professors from the DbContext.
      * Use a foreach loop in `Index.cshtml` to display the contents of that list.
3. Run your program fully now with CTRL+F5 or dotnet run.
4. Visit your website and check your work. If you see errors, debug!
      
Congratulations, you have combined ASP.NET Core + EF Core. Continue to the required Step 9 and optional Step 10 extra credit to explore more advanced capabilities.

## Step 9: Use a SelectList inside a Form

1.	Create a new Razor Page with Page Model (`Professor.cshtml` + `Professor.cshtml.cs`)
2.	Inside the Page Model, use a SelectList to create a drop down with the list of Professors.
      * The SelectList can display just the professor’s first name.
3.	Inside the Razor Page, create a new form using Bootstrap techniques. Within the form:
      * Place a `<select>` tag with the appropriate HTML code and tag helpers.
      * Add a Submit button.
4.	Your web page should look similar to the pictures below.

![Image of webpage 1](https://i.imgur.com/z7kyPpl.png)
![Image of webpage 2](https://i.imgur.com/mGSArfm.png)

## Step 10: Challenge Extra Credit - Making the Form work - Model Binding and OnPost()

1.	Add code to your Page Model and Razor Page so that the Submit button works.
2.	That means, once the user selects a professor and hits submit, your app should find that professor in the database and then display the selected professor back on the web page.
3.	See the picture below for an illustration of how your page should work.
4.	This will require the following techniques:
     * Model Binding
     * Using the asp-for tag helper to facilitate Model Binding
     * Adding code to your OnPost() method that will find the selected Professor
     * Adding code to your Razor Page that will display the selected Professor
5.	Good luck!

![Image of webpage 3](https://i.imgur.com/1m6v7e9.png)

## Submit your code to GitHub
