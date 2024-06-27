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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private MainWindow mainWindow;
        private string recipeName;
        public Page4(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            recipeName = mainWindow.CurrentRecipeName;
        }
        private void btnSubmit4_Click(object sender, RoutedEventArgs e)
        {
            string step = txtDescription.Text;
            mainWindow.ingredientDB.AddStep(step);
            mainWindow.recipeDB.AddStepToRecipe(recipeName, step);

            txtDescription.Text = "";

            if (mainWindow.ingredientDB.GetAllSteps().Count >= mainWindow.numOfSteps)
            {
                mainWindow.NavigateTo(new Page5(mainWindow));
            }
        }
    }
}
