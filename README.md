WPF Recipe App 💻
Overview
This application allows you to manage recipes, ingredients, and steps interactively using a WPF (Windows Presentation Foundation) interface.

Prerequisites
Before running the application, ensure you have the following installed:

Visual Studio (preferably the latest version)
.NET Framework (version compatible with your Visual Studio)
Getting Started
Clone the Repository:

Clone this repository to your local machine using Git:
bash
Copy code
git clone <repository-url>
Alternatively, download the repository as a ZIP file and extract it.
Open Solution in Visual Studio:

Launch Visual Studio.
Open the solution file WPFRecipeApp.sln located in the root directory of the cloned repository.
Restore NuGet Packages:

Once the solution is open, right-click on the solution in the Solution Explorer.
Select Restore NuGet Packages to ensure all necessary packages are installed.
Set Startup Project:

Right-click on the project WPFRecipeApp in the Solution Explorer.
Select Set as StartUp Project.
Build the Solution:

Press Ctrl + Shift + B or go to Build > Build Solution to compile the application.
Run the Application:

Press F5 or go to Debug > Start Debugging to run the application.
Navigate Through the Application:

Follow the on-screen instructions to navigate between pages (Page1, Page2, etc.), add ingredients and steps to recipes, and view recipes.
Usage
Adding Ingredients:

Enter the number of ingredients and the recipe name in Page1.
Fill out the ingredient details in Page2.
Adding Steps:

Specify the number of steps in Page3.
Enter step descriptions in Page4.
Viewing and Manipulating Recipes:

Navigate to Page5 to view and manipulate recipes.
Adjust ingredient quantities and step details using the provided buttons (Half, Double, Triple).
Contributing
Contributions are welcome. For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License.


FeedBack Section 📓

For the feedback given for part 2 I have tried to correct as much of it as possible but due to much troubleshootign and time restrictions I wasnt able to fix and implement them into my WPF application.

The first one I remember is that I hadnt used delegates correctly, I had tried to implement it correctly but due it it being complicated for me i decided to just do it another way and focas on the functionality of my WPF application.

The second one I remember if that the restart button wasnt a good button to be used for restarting the application to add a new recipe do to fix this I have renamed the button to make it do the user knows that the button is for entering a new recipe.
