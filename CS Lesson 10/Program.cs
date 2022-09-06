using CS_Lesson_10.Document_Programs;

namespace CS_Lesson_10;

class Program
{
    #region Delegate

    delegate void DocProgramFunc(DocumentProgram program , ref bool exit);

  public static void Choice(DocumentProgram program, ref bool exit)
    {
        while (!exit)
        {
            Console.Clear();
            Console.Write(@"
1. Open Document
2. Edit Document
3. Save Document
b. Back
e. Exit

Pls select: ");


            switch (Console.ReadLine()?.ToLower())
            {
                case "1":
                    Console.Clear();
                    program.OpenDocument();
                    Console.ReadKey(false);
                    break;
                case "2":
                    Console.Clear();
                    program.EditDocument();
                    Console.ReadKey(false);
                    break;
                case "3":
                    Console.Clear();
                    program.SaveDocument();
                    Console.ReadKey(false);
                    break;
                case "b":
                    exit = true;
                    break;
                case "e":
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\t\t\t\t\t\tGOOD BYE !");
                    Environment.Exit(0);
                    break;
                default:
                    try
                    {
                        throw new ArgumentException("\n\n\n\n\t\t\t\tUnknown command !");
                    }
                    catch (Exception ex)
                    {

                        Console.Clear();
                        Console.WriteLine(ex.Message);

                        Thread.Sleep(1500);
                        continue;
                    }

            }
        }


    }

    #endregion


    static void Main()
    {

        DocumentProgram docProgram;

        DocProgramFunc choice = Choice;

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.Write("Enter key (Press 0 if you want exit): ");
            
            bool userChoice = false;
            switch (Console.ReadLine()?.ToLower())
            {
                case "basic":
                    docProgram = new DocumentProgram();
                    choice(docProgram, ref userChoice);
                    break;

                case "pro":
                    docProgram = new ProDocumentProgram();
                    choice(docProgram, ref userChoice);
                    break;

                case "expert":
                    docProgram = new ExpertDocumentProgram();
                    choice(docProgram, ref userChoice);
                    break;

                case "0":
                    exit = true;
                    Console.WriteLine("\n\n\n\n\t\t\t\t\t\tGOOD BYE !");
                    break;

                default:
                    try
                    {
                        throw new ArgumentException("\n\n\n\n\t\t\t\tInvaid Key!");
                    }
                    catch (Exception ex)
                    {

                        Console.Clear();
                        Console.WriteLine(ex.Message);

                        Thread.Sleep(1500);
                        continue;
                    }
            }

        }







    }



}
