
using System.Text;

namespace SortManagerView;

public class View
{
    public string? Input { get; set; }
    private const int windowWidth = 130;
    private const int windowHeight = 30;

    #region CONSOLE_CONFIG_AND_STARTUP

    public void Setup()
    {
        Console.SetWindowSize(windowWidth, windowHeight);
        DisplayWelcomeScreen();
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

    public void ClearScreen()
    {
        Console.Clear();

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

    #endregion


    #region SCREENS

    public void DisplayWelcomeScreen()
    {
        DisplayAsciiPop();
        ClearUpToBoarder();
    }

    public void DisplaySortOptionScreen()
    {
        ConsoleWritesGreen();
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
        ConsoleWritesGreen();
        Console.WriteLine(@"Input Array Length.
Error will be shown if no length is given.
>> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayHappyOutputScreen(string arrayUnsorted, string arraySorted, double timeTaken)
    {
        CreateSuspense();
        ConsoleWritesGreen();
        Console.WriteLine($@"Output.
Array unsorted: {arrayUnsorted}
Array sorted: {arraySorted}
Time taken: {timeTaken} miliseconds
1 Again?
2 Exit?
>> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayInvalidSortMessage()
    {
        ConsoleWritesRed();
        DisplayInvalidInputMessage();
        DisplaySortOptionScreen();
    }

    private void DisplayInvalidInputMessage()
    {
        ConsoleWritesRed();
        Console.WriteLine($"Your input:{Input} is Invalid");
        ConsoleWritesGreen();
    }

    public void DisplayInvalidLengthMessage()
    {
        DisplayInvalidInputMessage();
        DisplayArrayLengthScreen();
    }

    public void DisplayAreYouSureYouWantToExitScreen()
    {
        ConsoleWritesRed();
        Console.WriteLine("Are you sure you want to exit?");
        ConsoleWritesGreen();
        Console.WriteLine($@"
            1 No
            2 Yes
            >> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    public void DisplayUnhappyOutputScreen(int[] arrayUnsorted, string errorMessage, double timeTaken)
    {
        ConsoleWritesRed();
        Console.WriteLine($@"Output.
Array unsorted: {arrayUnsorted}
Array sorted: ERROR: {errorMessage}
Time taken: {timeTaken} miliseconds
1 Again?
2 Exit?
>> ");
        Input = Console.ReadLine();
        ClearUpToBoarder();
    }

    #endregion

    #region AESTHETIC_METHODS_AND_STRINGS

    public void CreateSuspense()
    {
        ConsoleWritesGreen();
        ClearUpToBoarder();
        Thread.Sleep(1000);
        Console.WriteLine("Are you ready?");
        Thread.Sleep(1000);
        Console.WriteLine("3..");
        Thread.Sleep(1000);
        Console.WriteLine("2..");
        Thread.Sleep(1000);
        Console.WriteLine("1..");
        Thread.Sleep(2000);
        ClearUpToBoarder();
    }

    public string GetAsciiArt()
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
    public void ConsoleWritesGreen()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public void ConsoleWritesRed()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void ConsoleWritesNormal()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void DisplayAsciiPop()
    {
        ConsoleWritesNormal();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(GetAsciiArt());
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        Console.WriteLine(GetAsciiArt());
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.WriteLine(GetAsciiArt());
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine(GetAsciiArt());
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine(GetAsciiArt());
        Thread.Sleep(200);
    }
    #endregion
}