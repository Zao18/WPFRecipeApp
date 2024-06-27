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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private MainWindow mainWindow;
        private string recipeName;
        public Page2(MainWindow mainWindow, string recipeName)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.recipeName = recipeName;
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Starchy foods" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Vegetables and fruits" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Dry beans, peas, lentils and soya" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Chicken, fish, meat and eggs" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Milk and dairy products" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Fats and oil" });
            cbFoodGroup.Items.Add(new ComboBoxItem { Content = "Water" });

            cbFoodGroup.SelectedIndex = 0;
        }

        private void btnSubmit2_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtQuantity.Text, out double quantity) && double.TryParse(txtCalories.Text, out double calories))
            {
                string name = txtName.Text;
                string unit = txtUnit.Text;
                string foodGroup = ((ComboBoxItem)cbFoodGroup.SelectedItem).Content.ToString();

                mainWindow.ingredientDB.AddIngredient(name, quantity, unit, calories, foodGroup);

                mainWindow.recipeDB.AddIngredientToRecipe(recipeName, name, quantity, unit, calories, foodGroup);

                // Clear the input fields
                txtName.Text = "";
                txtQuantity.Text = "";
                txtUnit.Text = "";
                txtCalories.Text = "";
                cbFoodGroup.SelectedIndex = 0;

                if (mainWindow.ingredientDB.GetAllIngredients().Count >= mainWindow.numOfIngredients)
                {
                    double totalCalories = mainWindow.TotalCalories(mainWindow.ingredientDB.GetAllIngredients());
                    if (totalCalories >= 300)
                    {
                        MessageBox.Show("The total calories exceed 300");
                    }

                    // Navigate to Page3
                    mainWindow.NavigateTo(new Page3(mainWindow));
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Numbers");
            }
        }
    }
}
