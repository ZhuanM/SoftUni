using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());
            char[][] board = new char[boardSize][];

            for (int i = 0; i < boardSize; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            int maxRow = 0;
            int maxColumn = 0;
            int maxAttackedPositions = 0;

            int countOfRemovedKnights = 0;

            do
            {
                if (maxAttackedPositions > 0)
                {
                    board[maxRow][maxColumn] = '0';
                    maxAttackedPositions = 0;
                    countOfRemovedKnights++;
                }

                int currentAttackPosition = 0;
                for (int row = 0; row < boardSize; row++)
                {
                    for (int column = 0; column < boardSize; column++)
                    {
                        if (board[row][column]== 'K')
                        {
                            currentAttackPosition = CalculateAttackedPosition(row, column, board);
                            if (currentAttackPosition > maxAttackedPositions)
                            {
                                maxAttackedPositions = currentAttackPosition;
                                maxRow = row;
                                maxColumn = column;
                            }
                        }
                    }
                }

            } while (maxAttackedPositions > 0);

            Console.WriteLine(countOfRemovedKnights);
        }

        static int CalculateAttackedPosition(int row, int column, char[][] board)
        {
            var currentAttackPositions = 0;
            if (IsPositionAttacked(row - 2, column - 1, board))  currentAttackPositions++;
            if (IsPositionAttacked(row - 2, column + 1, board))  currentAttackPositions++;
            if (IsPositionAttacked(row - 1, column - 2, board))  currentAttackPositions++;
            if (IsPositionAttacked(row - 1, column + 2, board))  currentAttackPositions++;
            if (IsPositionAttacked(row + 1, column - 2, board))  currentAttackPositions++;
            if (IsPositionAttacked(row + 1, column + 2, board))  currentAttackPositions++;
            if (IsPositionAttacked(row + 2, column - 1, board))  currentAttackPositions++;
            if (IsPositionAttacked(row + 2, column + 1, board))  currentAttackPositions++;

            return currentAttackPositions;
        }

        static bool IsPositionWithinBoard(int row, int column, int boardSize)
        {
            return row >= 0 && row < boardSize && column >= 0 && column < boardSize;
        }

        static bool IsPositionAttacked(int row, int column, char[][] board)
        {
            return IsPositionWithinBoard(row, column, board[0].Length) && board[row][column] == 'K';
        }
    }
}