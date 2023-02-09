namespace array_deliverable;
class Program
{
    static void Main(string[] args)
    {

        int[] fibonacci = new int[25];

        fibonacci[0] = 1;
        fibonacci[1] = 1;

    

        for (int i = 2; i < fibonacci.Length; i++) 
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Fibnacci number " + fibonacci.Length);

        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.Write(" " + fibonacci[i]);
        }
        
            
    }
}

