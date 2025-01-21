static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello World!");
    }
}

static void Square()
{
    string text = Console.ReadLine();
    int number = 0;
    bool c = int.TryParse(text, out number);

    Console.WriteLine(number * number);
    Console.ReadLine();
}
Multi();
static void Multi()
{
    Console.WriteLine("Number 1:");
    string text1 = Console.ReadLine();
    Console.WriteLine("Number 2:");
    string text2 = Console.ReadLine();
    int number1 = 0;
    int number2 = 0;
    bool n1 = int.TryParse(text1, out number1);
    bool n2 = int.TryParse(text2, out number2);

    Console.WriteLine("Answer:");

    Console.WriteLine(number1 * number2);
    Console.ReadLine();
}

static void RightTriangleArea()
{
    Console.WriteLine("Ange basen för triangeln");
    string text3 = Console.ReadLine();
    Console.WriteLine("Ange höjden för triangeln");
    string text4 = Console.ReadLine();
    int number3 = 0;
    int number4 = 0;
    bool n3 = int.TryParse(text3, out number3);
    bool n4 = int.TryParse(text4, out number4);

    Console.WriteLine("Answer:");
    Console.WriteLine(number3 * number4);
    Console.ReadLine();
}