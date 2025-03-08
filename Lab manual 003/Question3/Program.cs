using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            MealCard mealCard1 = new MealCard();
            mealCard1.Input();
            mealCard1.DisplayBalance();

            mealCard1.Point();
            mealCard1.DisplayBalance();

            mealCard1.PurchaseFood();
            mealCard1.DisplayBalance();
        }
    }
}
