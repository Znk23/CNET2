Console.WriteLine("Hello, World!");


var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

// string - pomocí LINQu pomocí Select vytvořte nové pole kde jsou všechna slova uppercase

//1
//var result = strings.Select(x => x.ToUpper());

// 2 zjistěte pomocí LINQu jestli pole obsahuje pouze sudá čísla
bool isOnlyEvenNumbers = numbers.All(x => x % 2 == 0);
global::System.Console.WriteLine($"jsou vsechna cisla suda: {isOnlyEvenNumbers}");

// 3  vypsat čísla v poli numbers jako anglicka slova

//var result = numbers.Select(x => strings[x]);

// 4 - zjistit kolik obsahují všechna slova v poli strings dohromady písmen
var sumLetters = strings.Select(x => x.Length).Sum();
Console.WriteLine($"Všechna písmena mají {sumLetters} písmen");


//PrintList(result.ToList());



static void PrintList(List<string> listToPrint)
{
    foreach (var item in listToPrint)
    {
        Console.WriteLine(item);
    }
}





