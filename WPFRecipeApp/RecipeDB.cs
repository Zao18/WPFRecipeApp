using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRecipeApp
{
    public class RecipeDB
    {
        //Stores the lists of rescipes
        private SortedList<string, Recipe> recipes = new SortedList<string, Recipe>();

        //Method adds a new recipe name to the list
        public void AddRecipe(string name)
        {
            if (!recipes.ContainsKey(name)) //(GeeksforGeeks, 2018)
            {
                recipes[name] = new Recipe(name);
            }
        }

        //Method adds ingredients to the list
        public void AddIngredientToRecipe(string recipeName, string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredient ingredient = new Ingredient(name, quantity, unit, calories, foodGroup);
            recipes[recipeName].Ingredients.Add(ingredient);
        }

        //Method adds steps to the list
        public void AddStepToRecipe(string recipeName, string stepDescription)
        {
            Steps step = new Steps(stepDescription);
            recipes[recipeName].Steps.Add(step);
        }

        //Retrieves all recipes from the list
        internal List<Recipe> GetAllRecipes()
        {
            return recipes.Values.ToList();
        }

        //Retrieves a specific recipe by name
        internal Recipe GetRecipe(string name)
        {
            if (recipes.ContainsKey(name)) //(GeeksforGeeks, 2018)
            {
                return recipes[name];
            }
            return null;
        }

        //Clears all recipes from the list
        public void ClearRecipes()
        {
            recipes.Clear();
        }
    }
}

//“HashMap ContainsKey() Method in Java.” GeeksforGeeks, 22 June 2018, www.geeksforgeeks.org/hashmap-containskey-method-in-java/.