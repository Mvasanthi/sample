using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorCoins
{
    class Program
    {
        static void MakeChange(double origAmount, double
                            remainAmount, int[] coins)
        {
            
            if ((origAmount % 1.00) < origAmount)
            {
                coins[2] = (int)(origAmount / 1.00);
                remainAmount = origAmount % 1.00;
                origAmount = remainAmount;
            }
            if ((origAmount % 0.50) < origAmount)
            {
                coins[1] = (int)(origAmount / 0.50);
                remainAmount = origAmount % 0.50;
                origAmount = remainAmount;
            }
            if ((origAmount % 0.65) < origAmount)
            {
                coins[0] = (int)(origAmount / 0.65);
                remainAmount = origAmount % 0.65;
            }
        }
        static void ShowChange(int[] arr)
        {
            
            if (arr[2] > 0)
                Console.WriteLine("Number of Cola: " + arr[2]);
            if (arr[1] > 0)
                Console.WriteLine("Number of Chips: " + arr[1]);
            if (arr[0] > 0)
                Console.WriteLine("Number of Candy: " + arr[0]);
        }
        static void Main()
        {
            Console.WriteLine("Enter the amount you want to change:");
            double origAmount = Convert.ToDouble(Console.ReadLine());
            double toChange = origAmount;
            double remainAmount = 0.0;
            int[] coins = new int[3];
            MakeChange(origAmount, remainAmount, coins);

            Console.WriteLine("The best way to change " +
            toChange + " coins is: ");
            ShowChange(coins);
            Console.WriteLine("Thank You");
            Console.ReadLine();
        }
    }
}
