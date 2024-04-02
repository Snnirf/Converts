namespace Frinna_Candelaria_Number_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Seconds: ");
            string inputSeconds = Console.ReadLine();
            int seconds = int.Parse(inputSeconds);

            float minutes = seconds / 60;
            float hours = minutes / 60;
            float days = hours / 24;
            float months = days / (365f / 12); // Approximation: 365 days in a year on average

            Console.WriteLine("Seconds to Minutes: " + minutes + " Minutes");
            Console.WriteLine("Minutes to Hours: " + hours + " Hours");
            Console.WriteLine("Hours to Days: " + days + " Days");
            Console.WriteLine("Days to Months: " + months + " Months");
        }
    }
}

