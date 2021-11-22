using Playground;

Console.WriteLine("Hello, World!");


var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

// string - pomocí LINQu pomocí Select vytvořte nové pole kde jsou všechna slova uppercase

//1
//var result = strings.Select(x => x.ToUpper());

// 2 zjistěte pomocí LINQu jestli pole obsahuje pouze sudá čísla
//bool isOnlyEvenNumbers = numbers.All(x => x % 2 == 0);
//global::System.Console.WriteLine($"jsou vsechna cisla suda: {isOnlyEvenNumbers}");

// 3  vypsat čísla v poli numbers jako anglicka slova

//var result = numbers.Select(x => strings[x]);

// 4 - zjistit kolik obsahují všechna slova v poli strings dohromady písmen
//var sumLetters = strings.Select(x => x.Length).Sum();
//Console.WriteLine($"Všechna písmena mají {sumLetters} písmen");

// 5 - vytvořit novou kolekci obsahující dvojici lowercase i uppercase variantu
// 1. varianta
//var result = strings
//    .Select(slovo => new UpperLowerString(slovo))
//    .Select(x => $"upper:{x.UpperCase} lower:{x.LowerCase}");
// 2. varianta pomocí tuplu
//var result= strings.Select(slovo => (slovo.ToLower(), slovo.ToUpper()));

//PrintItems<(string, string)>(result);

//PrintList(result.ToList());

//6 frekvence výskytu jednotlivých písmen ve všech položkách pole strings (kombinovaně)

//var res = strings.Aggregate(
//    "", //start with empty string to handle empty list case
//    (current, next) => current + next);
//Console.WriteLine(res);

var aggregated = string.Join("", strings);  //spojeni slov do 1 retezce
var result = aggregated//pracuji se stringem jako s kolekci znaku
    .GroupBy(x => x) //seskupuji podle pismeneki (char v kolekci string)
    .Select(g => (g.Key, g.Count())) //udelam tuple obsahujici klic a pocet prvku
    .OrderByDescending(x => x.Item2)
    .ThenBy(x => x.Key)
    ;

PrintItems<(char, int)>(result);
 


static void PrintList(List<string> listToPrint)
{
    foreach (var item in listToPrint)
    {
        Console.WriteLine(item);
    }
}


static void PrintItems<T>(IEnumerable<T> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}


