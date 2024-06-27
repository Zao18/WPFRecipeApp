using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFRecipeApp
{
    /// <summary>
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        private MainWindow mainWindow;
        public Page5(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            DisplayRecipe();
        }

        //Method displays the recipe and its ingredients and steps
        private void DisplayRecipe()
        {
            string recipeText = "Recipe:\r\nIngredients:\r\n";

            // Get all ingredients from ingredientDB in mainWindow
            List<Ingredient> ingredients = mainWindow.ingredientDB.GetAllIngredients();

            foreach (Ingredient ingredient in ingredients) //(w3schools, 2024)
            {
                if (ingredient.Quantity == 16 && ingredient.Unit == "teaspoons")
                {
                    recipeText += $"1 cup of {ingredient.Name}\r\n";
                }
                else
                {
                    recipeText += $"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} with {ingredient.Calories} calories and is a {ingredient.FoodGroup} product\r\n";
                }
            }

            recipeText += "\r\nSteps:\r\n";

            // Get all steps from ingredientDB in mainWindow
            List<Steps> steps = mainWindow.ingredientDB.GetAllSteps();

            int stepNumber = 1;
            foreach (Steps step in steps) //(w3schools, 2024)
            {
                recipeText += $"Step {stepNumber}:\n {step.Step}\r\n";
                stepNumber++;
            }

            txtDisplay.Text = recipeText;
        }

        //Method displays the recipe and its ingredients and steps all halved
        private void btnHalf_Click(object sender, RoutedEventArgs e)
        {
            string recipeText = "Recipe:\r\nIngredients:\r\n";

            // Get all ingredients from ingredientDB in mainWindow
            List<Ingredient> ingredients = mainWindow.ingredientDB.GetAllIngredients();

            foreach (Ingredient ingredient in ingredients) //(w3schools, 2024)
            {
                if (ingredient.Quantity == 16 && ingredient.Unit == "teaspoons")
                {
                    recipeText += $"1 cup of {ingredient.Name}\r\n";
                }
                else
                {
                    recipeText += $"{ingredient.Quantity * 0.5} {ingredient.Unit} of {ingredient.Name} with {ingredient.Calories * 0.5} calories and is a {ingredient.FoodGroup} product\r\n";
                }
            }

            recipeText += "\r\nSteps:\r\n";

            List<Steps> steps = mainWindow.ingredientDB.GetAllSteps();

            int stepNumber = 1;
            foreach (Steps step in steps) //(w3schools, 2024)
            {
                recipeText += $"Step {stepNumber}:\n {step.Step}\r\n";
                stepNumber++;
            }

            txtDisplay.Text = recipeText;
        }

        //Method displays the recipe and its ingredients and steps all doubled
        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
            string recipeText = "Recipe:\r\nIngredients:\r\n";

            List<Ingredient> ingredients = mainWindow.ingredientDB.GetAllIngredients();

            foreach (Ingredient ingredient in ingredients) //(w3schools, 2024)
            {
                if (ingredient.Quantity == 16 && ingredient.Unit == "teaspoons")
                {
                    recipeText += $"1 cup of {ingredient.Name}\r\n";
                }
                else
                {
                    recipeText += $"{ingredient.Quantity * 2} {ingredient.Unit} of {ingredient.Name} with {ingredient.Calories * 2} calories and is a {ingredient.FoodGroup} product\r\n";
                }
            }

            recipeText += "\r\nSteps:\r\n";

            List<Steps> steps = mainWindow.ingredientDB.GetAllSteps();

            int stepNumber = 1;
            foreach (Steps step in steps) //(w3schools, 2024)
            {
                recipeText += $"Step {stepNumber}:\n {step.Step}\r\n";
                stepNumber++;
            }

            txtDisplay.Text = recipeText;
        }

        //Method displays the recipe and its ingredients and steps all tripled
        private void btnTriple_Click(object sender, RoutedEventArgs e)
        {
            string recipeText = "Recipe:\r\nIngredients:\r\n";

            List<Ingredient> ingredients = mainWindow.ingredientDB.GetAllIngredients();

            foreach (Ingredient ingredient in ingredients) //(w3schools, 2024)
            {
                if (ingredient.Quantity == 16 && ingredient.Unit == "teaspoons")
                {
                    recipeText += $"1 cup of {ingredient.Name}\r\n";
                }
                else
                {
                    recipeText += $"{ingredient.Quantity * 3} {ingredient.Unit} of {ingredient.Name} with {ingredient.Calories * 3} calories and is a {ingredient.FoodGroup} product\r\n";
                }
            }

            recipeText += "\r\nSteps:\r\n";

            List<Steps> steps = mainWindow.ingredientDB.GetAllSteps();

            int stepNumber = 1;
            foreach (Steps step in steps) //(w3schools, 2024)
            {
                recipeText += $"Step {stepNumber}:\n {step.Step}\r\n";
                stepNumber++;
            }

            txtDisplay.Text = recipeText;
        }

        //Resets all the values back to thier original states
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            string recipeText = "Recipe:\r\nIngredients:\r\n";

            List<Ingredient> ingredients = mainWindow.ingredientDB.GetAllIngredients();

            foreach (Ingredient ingredient in ingredients) //(w3schools, 2024)
            {
                if (ingredient.Quantity == 16 && ingredient.Unit == "teaspoons")
                {
                    recipeText += $"1 cup of {ingredient.Name}\r\n";
                }
                else
                {
                    recipeText += $"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} with {ingredient.Calories} calories and is a {ingredient.FoodGroup} product\r\n";
                }
            }

            recipeText += "\r\nSteps:\r\n";

            List<Steps> steps = mainWindow.ingredientDB.GetAllSteps();

            int stepNumber = 1;
            foreach (Steps step in steps) //(w3schools, 2024)
            {
                recipeText += $"Step {stepNumber}:\n {step.Step}\r\n";
                stepNumber++;
            }

            txtDisplay.Text = recipeText;
        }

        //Restarts the program
        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to restart?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) //(stackoverflow, 2010)
            {
                mainWindow.NavigateTo(new Page1(mainWindow)); //(Ilford Grammar School, 2015)

                mainWindow.ingredientDB.ClearIngredients();
                mainWindow.ingredientDB.ClearSteps();

                txtDisplay.Text = "";
            }
        }

        //Navigates to the next screen
        private void btnViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateTo(new Page6(mainWindow)); //(Ilford Grammar School, 2015)
        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//w3schools. 2024. [Website]
//Available at: https://www.w3schools.com/cs/cs_foreach_loop.php
//[Accessed 15 April 2024].

//stackoverflow. 2010. [Website]
//Available at: https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
//[Accessed 15 April 2024].

