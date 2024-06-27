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
        public void NavigateTo(Page page)
        {
            MainFrame.Navigate(page);
        }

        public double TotalCalories(List<Ingredient> ingredients)
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