namespace enhancedIfStatements
{
    internal class program
    {
        public static void Main()
        {
            checkWeather();
        }

        public static void checkWeather()
        {
            int temp;
            string weather;
            bool success = false;
            Console.WriteLine("Enter the current temperature.");

            while (!success)
            {
                string? tempInput = Console.ReadLine();

                if (success = int.TryParse(tempInput, out temp))
                {
                    weather = temp <= 15 ? "Too cold" : temp >= 16 && temp <= 28 ? "Just right" : "Too hot";
                    Console.WriteLine(weather);
                }

                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
        }
    }
}