class Program
{
    static void Main(string[] args)
    {
        // 1
        List<string> strings = new List<string> { "123", "2D4", "456", "ABC" };

        List<string> numericStrings = strings.Where(str => str.All(char.IsDigit)).ToList();

        Console.WriteLine("Строки, состоящие из цифр:");
        foreach (string numericString in numericStrings)
        {
            Console.WriteLine(numericString);
        }

        // 2
        List<int> numbers = new List<int> { -2, 4, -6, 8, 10, -12 };

        int maxPositive = numbers.Where(num => num > 0).Max();
        int minPositive = numbers.Where(num => num > 0).Min();

        Console.WriteLine($"Максимальное положительное число: {maxPositive}");
        Console.WriteLine($"Минимальное положительное число: {minPositive}");
        // 3
        List<string> words = new List<string> { "word", "apple", "word", "hello", "bed", "bed" };

        string mostFrequentWord = words
            .GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .Select(group => group.Key)
            .FirstOrDefault();

        Console.WriteLine($"Наиболее часто встречающееся слово: {mostFrequentWord}");
        // 4
        List<string> strings1 = new List<string> { "Hello!", "W", "o", "r", "ld!" };

        var sortedStrings = strings1.OrderByDescending(str => str.Length).ThenBy(str => str);

        Console.WriteLine("Отсортированный список строк:");
        foreach (string str in sortedStrings)
        {
            Console.WriteLine(str);
        }

        // 5
        List<DateTime> dates = new List<DateTime> { new DateTime(2022, 1, 1), new DateTime(2022, 3, 15), new DateTime(2022, 2, 10) };

        int dayDifference = dates.Max().Subtract(dates.Min()).Days;

        Console.WriteLine($"Разница в днях: {dayDifference}");
    }

}
