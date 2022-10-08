
using System.Text;

namespace SortManagerView;

public class View
{
    public string? Input { get; set; }
    public void Setup()
    {
        ClearScreen();
        Console.SetWindowSize(Console.LargestWindowWidth - 40, Console.LargestWindowHeight - 10);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(GetAsciiArt());
        ClearUpToBoarder();
    }

    public void ClearUpToBoarder()
    {
        for (int i = 50; i >= 40; i--)
        {
            ClearCurrentConsoleLine(i);
            Thread.Sleep(100);
        }
        Console.SetCursorPosition(0, 40);
    }

    public void ClearCurrentConsoleLine(int position)
    {
        int currentLineCursor = position;
        Console.SetCursorPosition(0, position);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public void DisplayInvalidSortMessage()
    {
        DisplayInvalidInputMessage();
        DisplaySortOptionScreen();
    }

    private void DisplayInvalidInputMessage()
    {
        Console.WriteLine($"Your input:{Input} is Invalid");
    }

    public void DisplayInvalidRetryMessage()
    {
        DisplayInvalidInputMessage();
        Console.WriteLine($@"
            1 Again?
            2 Exit?
            >> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void ClearScreen()
    {
        Console.Clear();
    }

    public void DisplayInvalidLengthMessage()
    {
        DisplayInvalidInputMessage();
        DisplayArrayLengthScreen();
    }

    public void DisplaySortOptionScreen()
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine
            (
                @"Choose your option.
                1 - Bubble sort
                2 - Merge sort
                3 - .NET sort
                4 - Exit  
                >> "
            );
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayArrayLengthScreen()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"Input Array Length.
            Error will be shown if no length is given.
            >> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayHappyOutputScreen(string arrayUnsorted, string arraySorted, double timeTaken)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($@"Output.
            Array unsorted: {arrayUnsorted}
            Array sorted: {arraySorted}
            Time taken: {timeTaken}
            1 Again?
            2 Exit?
            >> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayUnhappyOutputScreen(int[] arrayUnsorted, string errorMessage, double timeTaken)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($@"Output.
            Array unsorted: {arrayUnsorted}
            Array sorted: ERROR: {errorMessage}
            Time taken: {timeTaken}
            1 Again?
            2 Exit?
            >> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public static string GetAsciiArt()
    {
        return @"
               AAA               RRRRRRRRRRRRRRRRR   RRRRRRRRRRRRRRRRR                  AAA           YYYYYYY       YYYYYYY   
              A:::A              R::::::::::::::::R  R::::::::::::::::R                A:::A          Y:::::Y       Y:::::Y   
             A:::::A             R::::::RRRRRR:::::R R::::::RRRRRR:::::R              A:::::A         Y:::::Y       Y:::::Y   
            A:::::::A            RR:::::R     R:::::RRR:::::R     R:::::R            A:::::::A        Y::::::Y     Y::::::Y   
           A:::::::::A             R::::R     R:::::R  R::::R     R:::::R           A:::::::::A       YYY:::::Y   Y:::::YYY   
          A:::::A:::::A            R::::R     R:::::R  R::::R     R:::::R          A:::::A:::::A         Y:::::Y Y:::::Y      
         A:::::A A:::::A           R::::RRRRRR:::::R   R::::RRRRRR:::::R          A:::::A A:::::A         Y:::::Y:::::Y       
        A:::::A   A:::::A          R:::::::::::::RR    R:::::::::::::RR          A:::::A   A:::::A         Y:::::::::Y        
       A:::::A     A:::::A         R::::RRRRRR:::::R   R::::RRRRRR:::::R        A:::::A     A:::::A         Y:::::::Y         
      A:::::AAAAAAAAA:::::A        R::::R     R:::::R  R::::R     R:::::R      A:::::AAAAAAAAA:::::A         Y:::::Y          
     A:::::::::::::::::::::A       R::::R     R:::::R  R::::R     R:::::R     A:::::::::::::::::::::A        Y:::::Y          
    A:::::AAAAAAAAAAAAA:::::A      R::::R     R:::::R  R::::R     R:::::R    A:::::AAAAAAAAAAAAA:::::A       Y:::::Y          
   A:::::A             A:::::A   RR:::::R     R:::::RRR:::::R     R:::::R   A:::::A             A:::::A      Y:::::Y          
  A:::::A               A:::::A  R::::::R     R:::::RR::::::R     R:::::R  A:::::A               A:::::A  YYYY:::::YYYY       
 A:::::A                 A:::::A R::::::R     R:::::RR::::::R     R:::::R A:::::A                 A:::::A Y:::::::::::Y       
AAAAAAA                   AAAAAAARRRRRRRR     RRRRRRRRRRRRRRR     RRRRRRRAAAAAAA                   AAAAAAAYYYYYYYYYYYYY    


 
     SSSSSSSSSSSSSSS      OOOOOOOOO     RRRRRRRRRRRRRRRRR   TTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR   
   SS:::::::::::::::S   OO:::::::::OO   R::::::::::::::::R  T:::::::::::::::::::::TE::::::::::::::::::::ER::::::::::::::::R  
  S:::::SSSSSS::::::S OO:::::::::::::OO R::::::RRRRRR:::::R T:::::::::::::::::::::TE::::::::::::::::::::ER::::::RRRRRR:::::R 
  S:::::S     SSSSSSSO:::::::OOO:::::::ORR:::::R     R:::::RT:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::ERR:::::R     R:::::R
  S:::::S            O::::::O   O::::::O  R::::R     R:::::RTTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE  R::::R     R:::::R
  S:::::S            O:::::O     O:::::O  R::::R     R:::::R        T:::::T          E:::::E               R::::R     R:::::R
   S::::SSSS         O:::::O     O:::::O  R::::RRRRRR:::::R         T:::::T          E::::::EEEEEEEEEE     R::::RRRRRR:::::R 
    SS::::::SSSSS    O:::::O     O:::::O  R:::::::::::::RR          T:::::T          E:::::::::::::::E     R:::::::::::::RR  
      SSS::::::::SS  O:::::O     O:::::O  R::::RRRRRR:::::R         T:::::T          E:::::::::::::::E     R::::RRRRRR:::::R 
         SSSSSS::::S O:::::O     O:::::O  R::::R     R:::::R        T:::::T          E::::::EEEEEEEEEE     R::::R     R:::::R
              S:::::SO:::::O     O:::::O  R::::R     R:::::R        T:::::T          E:::::E               R::::R     R:::::R
              S:::::SO::::::O   O::::::O  R::::R     R:::::R        T:::::T          E:::::E       EEEEEE  R::::R     R:::::R
  SSSSSSS     S:::::SO:::::::OOO:::::::ORR:::::R     R:::::R      TT:::::::TT      EE::::::EEEEEEEE:::::ERR:::::R     R:::::R
  S::::::SSSSSS:::::S OO:::::::::::::OO R::::::R     R:::::R      T:::::::::T      E::::::::::::::::::::ER::::::R     R:::::R
  S:::::::::::::::SS    OO:::::::::OO   R::::::R     R:::::R      T:::::::::T      E::::::::::::::::::::ER::::::R     R:::::R
   SSSSSSSSSSSSSSS        OOOOOOOOO     RRRRRRRR     RRRRRRR      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR

______________________________________________________________________________________________________________________________
******************************************************************************************************************************
______________________________________________________________________________________________________________________________";
    }

    
} 