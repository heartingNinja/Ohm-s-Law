namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Lambda expression: (current, resistance) => current * resistance
        // It takes two parameters 'current' and 'resistance' representing the current and resistance values respectively.
        // It multiplies the current 'current' with the resistance 'resistance' to calculate the voltage.
        Func<int, int, int> calculateVoltage = (current, resistance) => current * resistance;
        Console.WriteLine("Start Ohm's law");

        while (true)
        {
            Console.WriteLine("Enter the current value (or 'b' to exit):");
            string currentInput = Console.ReadLine();

            if (currentInput.ToLower() == "b")
                break;

            int current;
            if (!int.TryParse(currentInput, out current))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the current.");
                continue;
            }

            while (true)
            {
                Console.WriteLine("Enter the resistance value (or 'b' to go back to current):");
                string resistanceInput = Console.ReadLine();

                if (resistanceInput.ToLower() == "b")
                    break;

                int resistance;
                if (!int.TryParse(resistanceInput, out resistance))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the resistance.");
                    continue;
                }

                int voltage = calculateVoltage(current, resistance);
                Console.WriteLine("The voltage is: " + voltage);
                break;
            }
        }
    }
}
