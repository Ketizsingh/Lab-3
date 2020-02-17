using System;

namespace Nikhil_Rawal_Week6Lab
{
    class Program
    {

        static void center(string mid)
        {
            Console.SetCursorPosition((Console.WindowWidth - mid.Length) / 2, Console.CursorTop);
            Console.WriteLine(mid);
        }            

    static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("Enter your full name");
                string name = Console.ReadLine();
                char[] alp = name.ToCharArray();
                center("**********Abstract art of your name**********");
                foreach (char ch in alp) 
                    
                {
                    int count = 0;

                    int index = (ch < 97 ? ch - 64 : ch - 96) ;
                    
                    
                    System.Text.StringBuilder line = new System.Text.StringBuilder("");
                    for (count = 0; count < index; count++) 
                    {
                        line.Append(ch); 
                    }
                    center(line.ToString()); 
                }
                center("*********************************************");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
            
    }
}
