using System;

namespace geta_m3_pp_week
{
    class HalfOfASquare
    {
        /**
         * PROBLEM: HALF OF A SQUARE
           Write a program that uses only two output statements, cout << "#" and cout << "\n",
           to produce a pattern of hash symbols shaped like half of a perfect 5 x 5 square (or a
           right triangle):
           #####
           ####
           ###
           ##
           #
         */
        public HalfOfASquare()
        {
            // Only allowed console writes:
            // Console.Write("#");
            // Console.WriteLine();

            int hashCount = 5;
            int rows = 5;

            // For each row.
            for (int i = 0; i < rows; i++)
            {
                // Write a line of hashes.
                for (int j = 0; j < hashCount; j++)
                {
                    Console.Write("#");
                }
                
                hashCount--;
                Console.WriteLine();
            }

        }
    }
}
