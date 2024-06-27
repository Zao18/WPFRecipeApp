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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private MainWindow mainWindow;
        public Page1(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            double num1 = 0;
            if (double.TryParse(txtNumber.Text, out num1))
            {
                mainWindow.numOfIngredients = Convert.ToInt32(txtNumber.Text);
                string name = txtRecipeName.Text;
                mainWindow.recipeDB.AddRecipe(name);
                mainWindow.NavigateTo(new Page2(mainWindow, name));
            }
            else
            {
                txtNumber.Text = "";
                MessageBox.Show("Please Enter a Number");
            }
        }
    }
}
