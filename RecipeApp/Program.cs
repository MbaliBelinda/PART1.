using System;

namespace RecipeApp
{
    class Recipe
    {
        // Define arrays to store ingredients and steps
        private string[] ingredients;
        private string[] steps;

        // Constructor to initialize arrays
        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new string[numIngredients];
            steps = new string[numSteps];
        }

        // Method to add an ingredient to the array
        public void AddIngredient(int index, string ingredient)
        {
            ingredients[index] = ingredient;
        }

        // Method to add a step to the array
        public void AddStep(int index, string step)
        {
            steps[index] = step;
        }

        // Method to display the full recipe, including ingredients and steps
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nSteps:");
            foreach (string step in steps)
            {
                Console.WriteLine(step);
            }
        }

        // Method to scale the recipe by a factor
        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                // Split the ingredient string to separate quantity and unit
                string[] parts = ingredients[i].Split(' ');
                double quantity = double.Parse(parts[0]);
                string unit = parts[1];

                // Scale the quantity based on the factor
                quantity *= factor;

                // Update the ingredient with the scaled quantity
                ingredients[i] = quantity.ToString() + " " + unit;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get input for the number of ingredients and steps
            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            // Create a new Recipe object
            Recipe recipe = new Recipe(numIngredients, numSteps);

            // Add ingredients to the recipe
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter ingredient " + (i + 1) + ":");
                recipe.AddIngredient(i, Console.ReadLine());
            }

            // Add steps to the recipe
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter step " + (i + 1) + ":");
                recipe.AddStep(i, Console.ReadLine());
            }

            // Display the original recipe
            recipe.DisplayRecipe();

            // Ask the user if they want to scale the recipe
            Console.WriteLine("\nScale the recipe by a factor of 0.5, 2, or 3?");
            double factor = double.Parse(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            // Display the scaled recipe
            Console.WriteLine("\nScaled Recipe:");
            recipe.DisplayRecipe();
        }
    }
}