// See https://aka.ms/new-console-template for more information
using Calculadora.Domain;
using Calculadora.Handlers;

var cache = new CacheHandler();
OutputHandler.Print(OutputHandler.GetWelcomeMessage());
Thread.Sleep(3000);

while (true)
{
    OutputHandler.Print(OutputHandler.GetOperationsMenu());
    var opt = Console.ReadLine();

    if (int.TryParse(opt, out int intOpt))
    {
        switch (intOpt)
        {
            case 0:
                {
                    OutputHandler.Print(OutputHandler.GetLastOperations(cache.Operations));
                    Console.ReadKey();
                }
                break;
            case 1:
                {
                    try
                    {
                        var input = InputHandler.GetNumbers();
                        var operation = new Operation(input.Item1, input.Item2, Calculadora.Domain.Enum.EOperationType.Sum);
                        cache.Save(operation);
                        OutputHandler.Print($"Resultado: {operation.Result}");
                        Console.ReadKey();
                    }
                    catch (ArgumentException ex)
                    {
                        OutputHandler.Print(ex.Message);
                        Thread.Sleep(2000);
                    }
                    
                }
                break;
            case 2:
                {
                    try
                    {
                        var input = InputHandler.GetNumbers();
                        var operation = new Operation(input.Item1, input.Item2, Calculadora.Domain.Enum.EOperationType.Subtraction);
                        cache.Save(operation);
                        OutputHandler.Print($"Resultado: {operation.Result}");
                        Console.ReadKey();
                    }
                    catch (ArgumentException ex)
                    {
                        OutputHandler.Print(ex.Message);
                        Thread.Sleep(2000);
                    }
                    
                }
                break;
            case 3:
                {
                    try
                    {
                        var input = InputHandler.GetNumbers();
                        var operation = new Operation(input.Item1, input.Item2, Calculadora.Domain.Enum.EOperationType.Multiplication);
                        cache.Save(operation);
                        OutputHandler.Print($"Resultado: {operation.Result}");
                        Console.ReadKey();
                    }
                    catch (ArgumentException ex)
                    {
                        OutputHandler.Print(ex.Message);
                        Thread.Sleep(2000);
                    }

                }
                break;
            case 4:
                {
                    try
                    {
                        var input = InputHandler.GetNumbers();
                        var operation = new Operation(input.Item1, input.Item2, Calculadora.Domain.Enum.EOperationType.Division);
                        cache.Save(operation);
                        OutputHandler.Print($"Resultado: {operation.Result}");
                        Console.ReadKey();
                    }
                    catch (ArgumentException ex)
                    {
                        OutputHandler.Print(ex.Message);
                        Thread.Sleep(2000);
                    }
                    
                }
                break;

        }
    }
    else if(opt.ToLower() == "s")
    {
        break;
    }
}
