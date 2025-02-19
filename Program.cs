namespace Homework_4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine();
        string str_1 = Console.ReadLine();

        CountWord words = new CountWord(str_1);
        Console.WriteLine(words.GetWordCount());

        //Two

        Console.WriteLine();
        string str = Console.ReadLine();

        Flip flip = new Flip();
        Console.WriteLine(flip.FlipChar(str));

        //Three

        Console.WriteLine();
        string test = Convert.ToString(Console.ReadLine());

        orderChecker word = new orderChecker();
        Console.WriteLine(word.OrderSorted(test));

        
        //Four

        Console.WriteLine();
        string input = Convert.ToString(Console.ReadLine());

        Console.WriteLine();
        int n = Convert.ToInt32(Console.ReadLine());

        Vowel extractor = new Vowel();
        Console.WriteLine(extractor.nVowel(input, n));

        

        //Five

        Console.WriteLine();
        string input1 = Convert.ToString(Console.ReadLine());

        Shift shift = new Shift();
        Console.WriteLine(shift.Change(input1));




    }
}

