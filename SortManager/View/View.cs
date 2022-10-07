﻿namespace View;

public class View
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        Console.SetWindowPosition(0, 0);
        Console.WriteLine(GetAsciiArt());
        //Get from controller, what to display.
        Console.WriteLine(@"dkfnskdnv
dsfgsfds
sdfsdfsdf
sdfsafs\SADF
DFSDFW
sdfs
.");
        ClearUpToBoarder();
    }

    public static void ClearUpToBoarder()
    {
        for (int i = 40; i < 60; i++)
        {
            ClearCurrentConsoleLine(i);
        }
        Console.SetCursorPosition(0, 40);
    }

    public static void ClearCurrentConsoleLine(int position)
    {
        int currentLineCursor = position;
        Console.SetCursorPosition(0, position);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public static void GetUserInput()
    {
        Console.ReadLine();
    }

    public static string DisplaySortOptionScreen()
    {
        return @"Choose your option
1 Bubble sort
2 Merge sort
3 .NET sort
4 Exit  
>>";
    }

    public static string DisplayArrayLengthScreen()
    {
        return @"Input Array Length
Error will be shown if no length is given.
>> ";
    }

    public static string DisplayHappyOutputScreen(int[] arrayUnsorted, int[] arraySorted, double timeTaken)
    {
        return @"Output
Array unsorted:
Array sorted:
Time taken:
1 Again?
2 Exit?
>>";
    }

    public static string DisplayUnhappyOutputScreen(int[] arrayUnsorted, string errorMessage, double timeTaken)
    {
        return @"Output
Array unsorted: {}
Array sorted: Error and why?
Time taken:
1 Again?
2 Exit?
>>";
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