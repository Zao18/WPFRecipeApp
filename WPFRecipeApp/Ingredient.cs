using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRecipeApp
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Unit = unit;
            this.Calories = calories;
            this.FoodGroup = foodGroup;
        }
    }

    //This is for steps
    internal class Steps
    {
        public string Step { get; set; }

        public Steps(string Step)
        {
            this.Step = Step;
        }
    }
}
