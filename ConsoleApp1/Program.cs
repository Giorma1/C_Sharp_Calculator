class Cal
{
    static void Calculator(string c, double a, double b)
    {
        double sum;
        try
        {
            if (c == "+") { sum = a + b; Console.WriteLine($" {a} + {b} = " + sum); }
            else if (c == "-") { sum = a - b; Console.WriteLine($" {a} - {b} = " + sum); }
            else if (c == "*") { sum = a * b; Console.WriteLine($" {a} * {b} = " + sum); }
            else if (c == "/") { sum = a / b; Console.WriteLine($" {a} / {b} = " + sum); }
            else if (c == "%") { sum = a % b; Console.WriteLine($" {a} % {b} = " + sum); }
            else { Console.WriteLine(" Invalid Operator!"); }
        }
        catch (FormatException)
        {
            Console.WriteLine(" Error: Invalid input format");
        }
    }

    static string GetValidOperatorInput()
    {
        string oper;
        while (true)
        {
            Console.Write(" Enter Operator: ");
            oper = Console.ReadLine();
            if (IsOperatorValid(oper))
            {
                break;
            }
            else
            {
                Console.WriteLine(" Error: Invalid operator. Please enter a valid operator (+, -, *, /, %).");
            }
        }
        return oper;
    }

    static bool IsOperatorValid(string input)
    {
        return input == "+" || input == "-" || input == "*" || input == "/" || input == "%";
    }

    static void Main(string[] args)
    {
        string oper;
        string num_1 = "";
        string num_2 = "";

        while (num_1 == "")
        {
            Console.Write(" Enter Number: ");
            num_1 = (Console.ReadLine());
            if (!double.TryParse(num_1, out _))
            {
                Console.WriteLine(" Error: Invalid input format for the first number. Please enter a valid number.");
                num_1 = ""; 
            }
        }

        oper = GetValidOperatorInput();

        while (num_2 == "")
        {
            Console.Write(" Enter Number: ");
            num_2 = (Console.ReadLine());
            if (!double.TryParse(num_2, out _))
            {
                Console.WriteLine(" Error: Invalid input format for the second number. Please enter a valid number.");
                num_2 = "";
            }
        }
        Calculator(oper, Convert.ToDouble(num_1), Convert.ToDouble(num_2));
        
        
    }
}
