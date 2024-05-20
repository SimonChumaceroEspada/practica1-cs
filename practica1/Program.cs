// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Lists
List<int> numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    numbers.Add(i);
}

Console.WriteLine("Elements of the list: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

numbers.RemoveAt(0);
numbers.RemoveAt(numbers.Count - 1);

Console.WriteLine("Updated List");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// Dictionaries
Dictionary<string, int> studentsInfo = new Dictionary<string, int>()
{
    { "Simon", 70},
    { "Santiago", 70 },
    { "Nicolas", 70 },
    { "Araceli", 70 },
    { "Diego", 70 },
};

foreach( var student in  studentsInfo)
{
    Console.WriteLine( $"{student.Key}: {student.Value}");
}