// See https://aka.ms/new-console-template for more information
using Calculadora.Handlers;

var cache = new CacheHandler();
OutputHandler.Print(OutputHandler.GetWelcomeMessage());
Thread.Sleep(3000);

while (true)
{
    OutputHandler.Print(OutputHandler.GetOperationsMenu());
    var opt = Console.ReadLine();
    var intOpt = 0;
    if (int.TryParse(opt, out intOpt))
    {
        switch (intOpt)
        {
            case 0:
                {
                    OutputHandler.Print(OutputHandler.GetLastOperations());
                }
                break;

        }
    }
}
