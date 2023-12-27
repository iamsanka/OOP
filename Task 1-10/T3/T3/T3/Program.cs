namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled :");
            int distance=Convert.ToInt32(Console.ReadLine());
            //calling the method
            Calculate(distance);
            
        }

        static void Calculate(int distance)
        {
            //get the random fuel price 
            Random random = new Random();
            double minimum = 1.75;
            double maximum = 2.50;
            double range = maximum - minimum;
            //getting the fule price
            double sample =random.NextDouble();
            double scaled = (sample * range) + minimum;
            float fuelPrice = (float)scaled;



            //calculate the cost
            int consumption = random.Next(6, 9);

            double liters = (consumption*distance)/100;
            Console.WriteLine($"liters {liters}");
            float cost = (float)liters * fuelPrice;
            

            Console.WriteLine($"Fuel consumption is {consumption} liters and it costs {Math.Round(cost, 2)} euros");
        }
    }
}