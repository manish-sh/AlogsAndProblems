using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var values = new HashSet<string>();

            for (int rowCounter = 0; rowCounter < 9; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < 9; columnCounter++)
                {
                    if (board[rowCounter][columnCounter] == '.')
                        continue;

                    if (values.TryGetValue($"R{rowCounter}{board[rowCounter][columnCounter]}", out _))
                        return false;

                    values.Add($"R{rowCounter}{board[rowCounter][columnCounter]}");

                    if (values.TryGetValue($"C{columnCounter}{board[rowCounter][columnCounter]}", out _))
                        return false;

                    values.Add($"C{columnCounter}{board[rowCounter][columnCounter]}");

                    if (values.TryGetValue($"B{rowCounter / 3}{columnCounter / 3}{board[rowCounter][columnCounter]}", out _))
                        return false;

                    values.Add($"B{rowCounter / 3}{columnCounter / 3}{board[rowCounter][columnCounter]}");
                }
            }

            return true;
        }
    }
}
