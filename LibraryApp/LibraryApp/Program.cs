


using LibraryApp.Controllers;
using Service.Helpers.Enums;
using Service.Helpers.Extentions;

Menues();

LibraryController library = new LibraryController();

while (true)
{

Operation: string operationStr = Console.ReadLine();

    int operation;

    bool isCoorectOperation = int.TryParse(operationStr, out operation);

    if (isCoorectOperation)
    {
        switch (operation)
        {
            case (int)Operations.CreateLibrary:
                library.Create();
                break;
            case 2:
                Console.WriteLine("library create");
                break;
            case 3:
                Console.WriteLine("library edit");
                break;
            case (int)Operations.GetAllLibraries:
                library.Create();
                break;
            case (int)Operations.GetLibraryById:
                library.GetById();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please write correct option");
                goto Operation;

        }


    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please write correct option format");
        goto Operation;
    }

}

static void Menues()
{
    ConsoleColor.DarkBlue.WriteConsole("Choose one option for working with application : " +
        "Library operations: 1 - Create, 2 - Delete, 3 - Edit , 4 - GetAll, 5 - GetById");
}