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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private MainWindow mainWindow;

        //Button sets the number of steps for the recipe and navigates to Page 4
        public Page3(MainWindow mainWindow) //(Ilford Grammar School, 2015)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void btnSubmit3_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtSteps.Text, out int num)) //(stackoverflow, 2019)
            {
                mainWindow.numOfSteps = num;
                mainWindow.NavigateTo(new Page4(mainWindow)); //(Ilford Grammar School, 2015)
            }
            else
            {
                MessageBox.Show("Please Enter a Number");
            }
        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//stackoverflow. 2019. [Website]
//Available at: https://stackoverflow.com/questions/55521149/converting-a-string-using-the-double-tryparse-method-in-c-sharp
//[Accessed 14 April 2024].