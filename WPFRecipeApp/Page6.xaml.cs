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
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        private MainWindow mainWindow;
        public Page6(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            PopulateComboBox();
        }

        //This populates the combo box
        private void PopulateComboBox()
        {
            cbDisplay.Items.Clear();
            List<Recipe> recipes = mainWindow.recipeDB.GetAllRecipes();
            recipes = recipes.OrderBy(r => r.Name).ToList(); //(stackoverflow, 2009)
            foreach (var recipe in recipes)
            {
                cbDisplay.Items.Add(recipe.Name);
            }
        }

        //Button to go back to Page 5
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateTo(new Page5(mainWindow)); //(Ilford Grammar School, 2015)
        }

        //Method displays the recipe selected
        private void btnDisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            string name = cbDisplay.SelectedItem?.ToString(); //(learn.microsoft, 2024)
            if (string.IsNullOrEmpty(name)) //(learn.microsoft, 2024)
            {
                MessageBox.Show("Please select a recipe from the dropdown menu.");
                return;
            }

            Recipe selectedRecipe = mainWindow.recipeDB.GetRecipe(name);

            if (selectedRecipe == null)
            {
                MessageBox.Show("Recipe not found.");
                return;
            }

            string recipeText = "Recipe:\r\n";

            recipeText += "Ingredients:\r\n";
            foreach (var ingredient in selectedRecipe.Ingredients)
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
            int stepCount = 1;
            foreach (var step in selectedRecipe.Steps)
            {
                recipeText += $"Step {stepCount}:\n {step.Step}\r\n";
                stepCount++;
            }

            txtDisplay.Text = recipeText;
        }

        //Button filters the Ingredients
        private void btnfilterIngredients_Click(object sender, RoutedEventArgs e)
        {

        }

        //Button filters the food group
        private void btnfilterFoodGroup_Click(object sender, RoutedEventArgs e)
        {

        }

        //Button filters the calories
        private void btnfilterCaloires_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//learn.microsoft. 2024. [Website]
//Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-8.0
//[Accessed 30 May 2024].

//learn.microsoft. 2024. [Website]
//Available at: https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-8.0
//[Accessed 30 May 2024].
