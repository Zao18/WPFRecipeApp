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
        public Page3(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void btnSubmit3_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtSteps.Text, out int num))
            {
                mainWindow.numOfSteps = num;
                mainWindow.NavigateTo(new Page4(mainWindow));
            }
            else
            {
                MessageBox.Show("Please Enter a Number");
            }
        }
    }
}
