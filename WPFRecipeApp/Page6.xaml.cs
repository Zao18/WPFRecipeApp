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
        public Page6(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            cbDisplay.Items.Clear();
            List<Recipe> recipes = mainWindow.recipeDB.GetAllRecipes();
            recipes = recipes.OrderBy(r => r.Name).ToList();
            foreach (var recipe in recipes)
            {
                cbDisplay.Items.Add(recipe.Name);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateTo(new Page5(mainWindow));
        }

        private void btnDisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            string name = cbDisplay.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(name))
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
    }
}
