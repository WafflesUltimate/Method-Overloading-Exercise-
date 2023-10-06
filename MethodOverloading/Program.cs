namespace MethodOverloading
{
    public class Program
    {

        static int Add(int num1, int num2)
        {

            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;
        }

        static string Add(int num1, int num2, bool isTrue)
        {
            int numTotal = num1 + num2;

            var t = (isTrue && numTotal > 1 && numTotal != '-') ? numTotal + " dollars" :
            (isTrue && numTotal > 0 && numTotal != '-') ? numTotal + " dollar" : $"You cannot have {numTotal} dollars.";
            Console.WriteLine(t);

            return (isTrue && numTotal > 1 && numTotal != '-') ? numTotal + " dollars" : 
            (isTrue && numTotal > 0 && numTotal != '-') ? numTotal + " dollar" : $"You cannot have {numTotal} dollars.";
        }

        static void Main(string[] args)
        {
            Add(-5, 2, true);
        }
    }
}
