namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subTotal;
            double tipPercentage;
            double grandTotal;

            Console.WriteLine("Welcome to the tip calculator!");
            Console.WriteLine("Please enter the sub total of the bill");
            subTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the percentage you would like to tip as a number");
            tipPercentage = Convert.ToDouble(Console.ReadLine());
            grandTotal = (tipPercentage / 100 + 1) * subTotal;
            Console.WriteLine("Sub Total: $" + Math.Round(subTotal, 2));
            Console.WriteLine("Tip Percentage: " + Math.Round(tipPercentage, 2) + "%");
            Console.WriteLine("Grand Total: $" + Math.Round(grandTotal, 2));
        }
    }
}
