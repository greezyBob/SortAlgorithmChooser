namespace View;

public class View
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(1500, 900);
        Console.WriteLine(GetAsciiArt());
    }

    public static int GetUserInput(string input)
    {
        throw new NotImplementedException();
    }

    public static void DisplaySortOptionScreen()
    {

    }

    public static void DisplayArrayLengthScreen()
    {

    }

    public static void DisplayArrayRangeScreen()
    {

    }

    public static void DisplayHappyOutputScreen()
    {

    }

    public static void DisplayUnhappyOutputScreen()
    {

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
   SSSSSSSSSSSSSSS        OOOOOOOOO     RRRRRRRR     RRRRRRR      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR";
    }
} 