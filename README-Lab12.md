## Your Name: Kareem Dana - LAB 12 Extra Credit SOLUTION


# Extra Credit Lab 12: Professor Web App Redux: Scaffolding and Related Data

In this lab exercise you will perform scaffolding, add a second entity class to your project, and connect that class with your existing one. This process is known as connecting related data.

## Step 0: Prepare Your Environment

1. Open your completed Lab 11 in Visual Studio Code

## Step 1: Scaffolding

1.  Bring in the required packages and tools for scaffolding:
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet tool install --global dotnet-aspnet-codegenerator
```
2.  Run the scaffolding command. Refer to the slides for the correct command. Note: You will have to make changes to the command to match your project.
3.  Once scaffolding is complete, run your project and visit the newly scaffolded pages.
      * Look at the Index page and ensure you have a list of all the professors.
      * Click “Create New” and make a new professor. Ensure that it is added to your list.
      * Click “Edit” and edit a professor. Ensure that your changes worked.
      * Click “Details” and see the details of a professor.
      * Click “Delete” and delete a professor. Ensure that the professor is removed.

## Step 2: Connect Related Data

1.   Add a Course entity class. 
     * Each course should have a CourseId and a Description property.
     * Each course is taught by ONE professor, and a professor may teach MANY courses. Put in the correct navigation properties.
     * Add the DbSet<Course> property to your DbContext class.
2.   Modify your SeedData class:
     * One professor should teach one course.
     * Another professor should teach at least two courses.
     * A third professor should teach no courses.
     * Delete your Migrations/ folder and your database.db file. Re-run your migrations.
3.   **PAUSE**. Run your project. If you see build errors, debug! You should not see any changes on your website yet. Just make sure that it runs and looks OK.

## Step 3: Display your courses (Read part of CRUD)

1.   Modify the Details page so that it shows each course for each professor.
     * Alter the Page Model to bring in the courses using .Include()
     * Alter the Razor Page to loop through each course and display them.
     * See Figure 1 for an illustration.

## Step 4: Delete a course (Delete part of CRUD)

1.   Pick one of the two techniques shown in the slides and implement it.
     * Technique one is to create a Delete button inside the Details page
     * Technique two is to create a separate Delete page with a SelectList
     * Implement BOTH techniques for **extra credit.**
     * See Figures 1 and 2 for illustrations

## Step 5: Create a new course (Create part of CRUD)

1.   Create an AddCourse.cshtml Razor Page and AddCourse.cshtml.cs Page Model
2.   Refer to Figure 2 for an example. When the user hits Submit, the page should redirect back to the Index page.
3.   Use a SelectList to allow the user to select from a drop down menu which Professor they want to teach the course.
            
            
![Figure 1](https://i.imgur.com/SnGPjXq.png)Figure 1: Details Page Listing Courses & Delete Button


![Figure 2](https://i.imgur.com/xKhC5uF.png)Figure 2: Delete Course Page


![Figure 3](https://i.imgur.com/P2B75to.png)Figure 2: Create Course Page