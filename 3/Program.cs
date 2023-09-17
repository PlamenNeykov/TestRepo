namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double costForFlowers = 0;
            double restSum = 0;

            if (name == "Roses")
            {
                if (count <= 80)
                {
                    costForFlowers = count * 5;
                }
                else
                {
                    costForFlowers = count * 5 * 0.9;
                }
            }
            else if (name == "Dahlias")
            {
                if (count <= 90)
                {
                    costForFlowers = count * 3.8;
                }
                else
                {
                    costForFlowers = count * 3.8 * 0.85;
                }

            }
            else if (name == "Tulips")
            {
                if (count <= 80)
                {
                    costForFlowers = count * 2.8;
                }
                else
                {
                    costForFlowers = count * 2.8 * 0.85;
                }

            }
            else if (name == "Narcissus")
            {
                if (count < 120)
                {
                    costForFlowers = count * 3 * 1.15;
                }
                else
                {
                    costForFlowers = count * 3;
                }

            }
            else if (name == "Gladiolus")
            {
                if (count < 80)
                {
                    costForFlowers = count * 2.5 * 1.2;
                }
                else
                {
                    costForFlowers = count * 2.5;
                }
            }

            if (costForFlowers > budget)
            {
                restSum = costForFlowers - budget;
                string s = $"{restSum:0.00}";
                Console.WriteLine($"Not enough money, you need {s} leva more.");

            }
            else
            {
                restSum = budget - costForFlowers;
                string s = $"{restSum:0.00}";
                Console.WriteLine($"Hey, you have a great garden with {count} {name} and {s} leva left.");
            }
        }
    }
}