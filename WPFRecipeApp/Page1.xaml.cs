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
        public Page1(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        //Button sets the number of ingredients and recipe name, then navigates to Page 2
        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            double num1 = 0;
            if (double.TryParse(txtNumber.Text, out num1))
            { //(stackoverflow, 2019)
                mainWindow.numOfIngredients = Convert.ToInt32(txtNumber.Text);
                string name = txtRecipeName.Text;
                mainWindow.recipeDB.AddRecipe(name);
                mainWindow.CurrentRecipeName = name;
                mainWindow.NavigateTo(new Page2(mainWindow)); //(Ilford Grammar School, 2015)
            }
            else
            {
                txtNumber.Text = "";
                MessageBox.Show("Please Enter a Number");
            }
        }
    }
}

//stackoverflow. 2019. [Website]
//Available at: https://stackoverflow.com/questions/55521149/converting-a-string-using-the-double-tryparse-method-in-c-sharp
//[Accessed 14 April 2024].

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.
