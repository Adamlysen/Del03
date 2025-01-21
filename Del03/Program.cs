static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello World!");
    }
}

static int Square()
{
    int SquareNumber = GetNumberInput();

    return SquareNumber * SquareNumber;
}
static int Multi()
{
    Console.WriteLine("Number 1:");
    int number1 = GetNumberInput();
    Console.WriteLine("Number 2:");
    int number2 = GetNumberInput();

    return number1 * number2;
}

static int RightTriangleArea()
{
    Console.WriteLine("Ange basen för triangeln");
    int length = GetNumberInput();
    Console.WriteLine("Ange höjden för triangeln");
    int height = GetNumberInput();

    return length * height / 2;
}

static int GetNumberInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Var god ange ett giltigt nummer:");
            }
        }
    }

    Hello32();
    Square();
    Multi();
    RightTriangleArea();