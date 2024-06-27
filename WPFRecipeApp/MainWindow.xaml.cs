using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IngredientDB ingredientDB = new IngredientDB();
        public RecipeDB recipeDB = new RecipeDB();
        public int numOfIngredients;
        public int numOfSteps;
        public int count = 1;
        public double totalCalories = 0;
        public string CurrentRecipeName { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1(this));
        }
        //Method to navigate to a specified page
        public void NavigateTo(Page page) //(Ilford Grammar School, 2015)
        {
            MainFrame.Navigate(page);
        }

        //Method to calculate the total calories of a list of ingredients
        public double TotalCalories(List<Ingredient> ingredients) //(stackoverflow, 2011)
        {
            double totalCalories = 0;
            foreach (var ingredient in ingredients)
            {
                totalCalories += ingredient.Calories * ingredient.Quantity; 
            }
            return totalCalories;
        }
    }
}

//Ilford Grammar School. “C# WPF and GUI - Pages and Navigation.” YouTube, 11 Nov. 2015,
//www.youtube.com/watch?v=aBh0weP1bmo&list=LL&index=2&ab_channel=IlfordGrammarSchool. Accessed 27 June 2024.

//stackoverflow. 2011. [Website]
//Available at: https://stackoverflow.com/questions/3082467/c-sharp-delegates-events
//[Accessed 30 May 2024].