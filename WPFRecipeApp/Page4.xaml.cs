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
        public Page4(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            recipeName = mainWindow.CurrentRecipeName;
        }

        //Button adds a step to the recipe and navigates to Page 5
        private void btnSubmit4_Click(object sender, RoutedEventArgs e)
        {
            string step = txtDescription.Text;
            mainWindow.ingredientDB.AddStep(step);
            mainWindow.recipeDB.AddStepToRecipe(recipeName, step);

            txtDescription.Text = "";

            if (mainWindow.ingredientDB.GetAllSteps().Count >= mainWindow.numOfSteps) //(BillWagner, 2024)
            {
                mainWindow.NavigateTo(new Page5(mainWindow)); //(Ilford Grammar School, 2015)
            }
        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//BillWagner. “Programming Concepts(C#).” Learn.microsoft.com, learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/.
