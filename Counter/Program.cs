int number = 1000;

while (true)
{
    if (number > 0)
    {
        Console.WriteLine("Techno Time\n");
        Thread.Sleep(number);

        number -= 20;

        Console.Clear();
    }
}