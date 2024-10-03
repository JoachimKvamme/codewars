using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		//Code here...
    List<int> numbersList = new List<int>();
    
    foreach (var item in numbers)
    {
        numbersList.Add(item);
    }
    int lowestNumber = numbers[0];
    int secondLowestNumber = numbers[1];

    foreach (var item in numbersList)
    {
        if (item < lowestNumber) {
            lowestNumber = item;
        }
    }
    numbersList.Remove(lowestNumber);

    foreach (var item in numbersList)
    {
        if (item < secondLowestNumber) {
            secondLowestNumber = item;
        }
    }

    
    return lowestNumber + secondLowestNumber;
	}
}

public class Persist 
{
	public static int Persistence(long n) 
	{

		// your code
        int multiplicationCount = 0;
        int product = unchecked((int)n);
        while (product > 9)
        {   
            string numberString = product.ToString();
            char[] numberCharArray = numberString.ToCharArray();
            product = 1;
            foreach (var item in numberCharArray)
            {
                string stringDigit = item.ToString();
                int factor = Int32.Parse(stringDigit);
                product *= factor;
            }
            multiplicationCount += 1;
        }
        return multiplicationCount;
	}
}

public static class KataTwo
{
    public static string Disemvowel(string str)
    {

        /*for (int i = 0; i < str.Length; i++)
        {
            switch (str[i]) {
                case 'a':
                case 'A':
                    str = str.Remove(i, 1);
                    break;
                case 'e':
                case 'E':
                    str = str.Remove(i, 1);
                    break;
                case 'i':
                    str = str.Remove(i, 1);
                    break;
                case 'I':
                    str = str.Remove(i, 1);
                    break;
                case 'o':
                case 'O':
                    str = str.Remove(i, 1);
                    break;
                case 'u':
                case 'U':
                    str = str.Remove(i, 1);
                    break;
                default:
                    break;
            }
           
        }*/
        str = Regex.Replace(str, @"[aAeEiIoOuU]", "");
         return str;
    }

    public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!
    for (int i = 0; i < str.Length; i++)
    {
        char testChar = str[i];
        str = str.Remove(i, 1);
        bool checkIso = Regex.IsMatch(str, $@"{testChar}");
        if (checkIso == true) {
            return false;
        }

    }
    return true;
  }

    public static int DuplicateCount(string str)
  {
    int count = 0;
    str = str.ToLower();
    for (int i = 0; i < str.Length; i++)
    {
        char testChar = str[i];
        str = str.Remove(i, 1);
        bool checkForDuplicate = Regex.IsMatch(str, $@"{testChar}");
        if (checkForDuplicate == true) {
            count += 1;
            str = Regex.Replace(str, $@"{testChar}", "");
            Console.WriteLine(str);
            i = 0;
        }    
    }

  return count;
  }




         public static int find_it(int[] seq) 
      {

        foreach (var item in seq)
        {
            int itemCount = seq.Count(i => i == item);
            Console.WriteLine($"{item} occurs {itemCount} times in the array");
            if (itemCount != 1 && itemCount % 2 != 0) {
                return item;
            }
        }

        return -1;
      }

         public static int Find(int[] integers)
    {
        int targetInt = 0;
        int countEven = 0;
        int countOdd = 0;
        int odd = 0;
        int even = 0;
        foreach (var item in integers)
        {
            if (item % 2 == 0) {
                countEven += 1;
                if (countEven == 1) {
                    even = item;
                }
            }
            if (item % 2 != 0) {
                countOdd += 1;
                if (countOdd == 1) {
                    odd = item;
                }
            }

        }
            if (countEven == 1) {
                targetInt = even;
            } else if (countOdd == 1) {
                targetInt = odd;
            }

            return targetInt;
        }




        public static IEnumerable<int> Stream()
   {
        List<int> primeList = new List<int>();

        int numberIndex = 1;
        while(numberIndex < 10_000_000) {
            if (IsPrime(numberIndex) == true) {
                primeList.Add(numberIndex);
                Console.WriteLine(numberIndex);
            }
            numberIndex += 1;
        }
       return primeList;
   }

   public static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
          
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
}


public static int FindEvenIndex(int[] arr)
  {
    //Code goes here!
    int sumLeft = 0;
    int sumRight = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        for (int item = i + 1; item < arr.Length; item++)
        {
            sumRight += arr[item];
        }
        for (int item = i - 1; item > -1; item--)
        {
            sumLeft += arr[item];
        }
        Console.WriteLine(sumLeft);
        Console.WriteLine(sumRight);
        if (sumRight == sumLeft) {
            return i;
        }
        sumLeft = 0;
        sumRight = 0;
    }

    return -1;
  }

   public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)

    return a.Where(x=>!b.Contains(x)).ToArray();

  }

  public static string AlphabetPosition(string text)
  {
    
    text = text.ToLower();
    text = Regex.Replace(text, @"[^a-zA-Z]", "");
    text = Regex.Replace(text, @"a", "1 ");
    text = Regex.Replace(text, @"b", "2 ");
    text = Regex.Replace(text, @"c", "3 ");
    text = Regex.Replace(text, @"d", "4 ");
    text = Regex.Replace(text, @"e", "5 ");
    text = Regex.Replace(text, @"f", "6 ");
    text = Regex.Replace(text, @"g", "7 ");
    text = Regex.Replace(text, @"h", "8 ");
    text = Regex.Replace(text, @"i", "9 ");
    text = Regex.Replace(text, @"j", "10 ");
    text = Regex.Replace(text, @"k", "11 ");
    text = Regex.Replace(text, @"l", "12 ");
    text = Regex.Replace(text, @"m", "13 ");
    text = Regex.Replace(text, @"n", "14 ");
    text = Regex.Replace(text, @"o", "15 ");
    text = Regex.Replace(text, @"p", "16 ");
    text = Regex.Replace(text, @"q", "17 ");
    text = Regex.Replace(text, @"r", "18 ");
    text = Regex.Replace(text, @"s", "19 ");
    text = Regex.Replace(text, @"t", "20 ");
    text = Regex.Replace(text, @"u", "21 ");
    text = Regex.Replace(text, @"v", "22 ");
    text = Regex.Replace(text, @"w", "23 ");
    text = Regex.Replace(text, @"x", "24 ");
    text = Regex.Replace(text, @"y", "25 ");
    text = Regex.Replace(text, @"z", "26 ");
    text = text.Trim();
    return text;
  }

   public static bool Scramble(string str1, string str2) 
    {
        char[] str1CharArray = str1.ToCharArray();
        foreach (var item in str1CharArray)
        {
            str2 = Regex.Replace(str2, $@"{item}", "");
        }
        if (str2 == "") {
            return true;
        } else {
            return false;
        }
    }

    public static string LongestConsec(string[] strarr, int k) 
    {

        int strarrLength = 0;
        string strarrCon = "";
        string longestStrarrCon = "";

        for (int i = 0; i < strarr.Length; i++)
        {
            strarrCon = strarr[i];
            if ((strarr.Length - i) - k >= 0) {
                for (int item = 1; item < k; item++)
            {
                if (k > 1) {
                    strarrCon = strarrCon + strarr[i + item];
                if (strarrCon.Length > strarrLength) {
                    strarrLength = strarrCon.Length;
                    longestStrarrCon = strarrCon;

                } 
               
                
                }
                 
                
            }
            if (strarrCon.Length > strarrLength) {
                        strarrLength = strarrCon.Length;
                        longestStrarrCon = strarrCon;
                    }
            }
            
        }
        
      if (strarr.Length == 0 || strarr.Length < k || k <= 0){
        return "";
      } else {
        return longestStrarrCon;
      }
    }

}