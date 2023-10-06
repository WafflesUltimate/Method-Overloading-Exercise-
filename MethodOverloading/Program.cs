namespace MethodOverloading
{
    public class Program
    {

        static int Add(int num1, int num2)
        {
            int numTotal = num1 + num2;
            Console.WriteLine(numTotal);
            return numTotal;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            decimal numTotal = num1 + num2;
            Console.WriteLine(numTotal);
            return numTotal;
        }

        static string Add(int num1, int num2, bool isTrue)
        {
            int numTotal = num1 + num2;

            var t = (isTrue && numTotal > 1 && numTotal != '-') ? numTotal + " dollars" :
            (isTrue && numTotal > 0 && numTotal != '-') ? numTotal + " dollar" : $"You cannot have {numTotal} dollars.";
            Console.WriteLine(t);

            return (isTrue && numTotal > 1 && numTotal != '-') ? numTotal + " dollars" : 
            (isTrue && numTotal < 0 && numTotal != '-') ? numTotal + " dollar" : $"You cannot have {numTotal} dollars.";
        }

        static void Main(string[] args)
        {
            Add(4, 5);

            Add(13.5m, 3.3m);

            Add(-5, 2, true);
        }
    }
}
