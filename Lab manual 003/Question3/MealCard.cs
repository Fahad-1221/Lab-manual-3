using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class MealCard
    {
        public string StudentName;
        public int Balance;

        public void Input()
        {
            Console.Write("Name of the student: ");
            StudentName = Console.ReadLine();
            Console.Write("Enter the balance of student : ");
            Balance = int.Parse(Console.ReadLine());
        }
        public void Point()
        {
            int n;
            Console.Write("Enter new amount of balance: ");
            n = int.Parse(Console.ReadLine());
            Balance = Balance + n;

        }
        public void PurchaseFood()
        {
            int points;
            Console.Write("Amount of Points to buy Food: ");
            points = int.Parse(Console.ReadLine());
            if (points <= 0)
            {
                Console.WriteLine("Invalid Amount.You have insufficient Points");
                return;
            }
            if (Balance >= points)
            {
                Balance -= points;
                Console.WriteLine($"Food Purchased by {points}points. Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine ("Insufficient Balance");
            }

        }
        public void DisplayBalance()
        {
            Console.WriteLine($"{StudentName}'s Meal Card Balance: {Balance}points"); 
        }
    }
}
