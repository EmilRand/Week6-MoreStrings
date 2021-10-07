using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string helloW = "Hello World!".ToLower();
            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
              if (helloW[i] == 'h')
              {
                    counterH++;
              }
            else if (helloW[i] == 'o')
                {
                    counterL++;
                }
            else if (helloW[i] == 'o')
                {
                    counterO++;
                }
            else
                {
                    continue;
                }

                Console.WriteLine($"lauses{helloW} on {counterH} 'h' tähte, {counterL} 'l' tähte ja {counterO} 'o' tähte");
            }
               

            
        }
    }
}
