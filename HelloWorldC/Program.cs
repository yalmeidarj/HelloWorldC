
divisibleByThree();
static void divisibleByThree()
{
    int sum = 0;
    for (int index = 1; index <= 20; index++)
    {
        var names = new List<string> { "<name>", "Ana", "Felipe" };
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }

    Console.WriteLine($"The sum of all numbers divisible by 3 is {sum}!");
}

