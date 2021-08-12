using System;
using System.Threading;

namespace geta_m3_pp_week
{
    class PingPong
    {
        string[] arr;
        int pos = 0;
        int width = 11;
        string ball = "X";
        public PingPong()
        {
            width = 11;
            pos = 0;
            arr = new string[width];

            // Animate stuffz!
            bool moveRight = true;
            for (int i = 0; i < 1000; i++)
            {
                if (pos == 0) moveRight = true;
                if (pos == arr.Length) moveRight = false;

                // Print to screen:
                // Wait before printing (so it's not instantly over).
                Thread.Sleep(50);
                
                // Print the stage.
                PrintStage();

                // Handle change of direction (if any).
                if (moveRight)
                {
                    // Move right.
                    // If not OOB.
                    if (pos < arr.Length)
                    {
                            pos++;
                    }
                } else {
                    // Move left.
                    
                    // If not OOB.
                    if (pos > 0)
                    {
                        pos--;
                    }
                }
            }
        }

        private void PrintStage()
        {
            // Move cursor to start of line.
            Console.Write("\r");

            // Print the stage:
            Console.Write("|");
            
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == pos)
                {
                    Console.Write(ball);
                } else
                {
                    Console.Write(" ");
                }
            }

            Console.Write("|");
        }
    }
}
