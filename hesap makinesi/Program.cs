using System;
class Program {
    static void Main(){
        double num1,num2;
        string operation;
        Console.WriteLine("Calculator");
        Console.Write("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number:");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose the operation you want to perform");
        Console.WriteLine("Addition (+)");
        Console.WriteLine("Subtraction (-)");
        Console.WriteLine("Multiplication (*)");
        Console.WriteLine("Division (/)");
        Console.Write("Enter your choice: ");
        operation = Console.ReadLine();

        // İşlem sonucunu hesapla ve ekrana yazdır
        double result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operation type.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"Result: {result}");
        }

        // Uygulamanın kapanmasını bekleyin
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}

       


