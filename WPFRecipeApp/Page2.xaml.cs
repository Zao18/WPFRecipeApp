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
        public Page2(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            PopulateComboBox();
            recipeName = mainWindow.CurrentRecipeName;
        }

        //This populates the combo box
        private void PopulateComboBox() //(Coding Under Pressure, 2020)
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

        //Button adds an ingredient to the current recipe and navigates to Page 3
        private void btnSubmit2_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtQuantity.Text, out double quantity) && double.TryParse(txtCalories.Text, out double calories))
            {
                string name = txtName.Text;
                string unit = txtUnit.Text;
                string foodGroup = ((ComboBoxItem)cbFoodGroup.SelectedItem).Content.ToString(); //(Coding Under Pressure, 2020)

                mainWindow.ingredientDB.AddIngredient(name, quantity, unit, calories, foodGroup);

                mainWindow.recipeDB.AddIngredientToRecipe(recipeName, name, quantity, unit, calories, foodGroup);

                txtName.Text = "";
                txtQuantity.Text = "";
                txtUnit.Text = "";
                txtCalories.Text = "";
                cbFoodGroup.SelectedIndex = 0; //(stackoverflow, 2012)

                if (mainWindow.ingredientDB.GetAllIngredients().Count >= mainWindow.numOfIngredients) //(learn.microsoft, 2024)
                {
                    double totalCalories = mainWindow.TotalCalories(mainWindow.ingredientDB.GetAllIngredients()); //(learn.microsoft, 2024)
                    if (totalCalories >= 300)
                    {
                        MessageBox.Show("The total calories exceed 300");
                    }
                    mainWindow.NavigateTo(new Page3(mainWindow)); //(Ilford Grammar School, 2015)
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Numbers");
            }
        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//Coding Under Pressure. “How to Populate a ComboBox in Codebehind WPF C# Tutorial.” YouTube, 30 Apr. 2020, 
//www.youtube.com/watch?v=4rU9yAkgGdk&ab_channel=CodingUnderPressure. Accessed 27 June 2024.

//stackoverflow. 2012. [Website]
//Available at: https://stackoverflow.com/questions/1602097/what-does-the-operator-do
//[Accessed 30 May 2024].

//learn.microsoft. 2024. [Website]
//Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-8.0
//[Accessed 30 May 2024].
