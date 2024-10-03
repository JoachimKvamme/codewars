namespace codewars;

class Program
{
    static void Main(string[] args)
    {
        string input = "rkqodlw";
        string inputString = "world";
        int[] array = {1,2,3,4,3,2,1};
        int[] arrayTwo = {1,2,3,4, 8, 9, 10, 3,2,1};
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Kata.sumTwoSmallestNumbers(array));
        Console.WriteLine(KataTwo.Disemvowel("Hai hai jai skade dai!"));
        Console.WriteLine(KataTwo.IsIsogram("testavisogram"));
       // Console.WriteLine(KataTwo.DuplicateCount("IndivisibilitiesABBA"));
       // Console.WriteLine(KataTwo.find_it(array));
        //Console.WriteLine(KataTwo.Find(array));
        //Console.WriteLine(KataTwo.Stream());
        //Console.WriteLine(KataTwo.FindEvenIndex(array));
        Console.WriteLine(KataTwo.ArrayDiff(array, arrayTwo));
        Console.WriteLine(KataTwo.AlphabetPosition(input));
        Console.WriteLine(KataTwo.Scramble(input, inputString));
        Console.WriteLine(KataTwo.Scramble("cedewaraaossoqqyt", "codewars"));
        Console.WriteLine(KataTwo.Scramble("katas", "steak")); 
        Console.WriteLine(KataTwo.LongestConsec(["ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"], 1));

    }
}

