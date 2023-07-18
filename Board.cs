using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    internal class Board {
        private string[,] board;
        

        public Board()
        {
            this.board = new string[,]{
                {"X", "2", "3"},
                {"4", "O", "6" },
                {"7", "8", "9" }
            };
        }

        private string[,] colorBord(string[,] board) {
            string[,] board_colored = new string[3, 3];
            //{
            //    { $"{board[0, 0]}", $"{board[0, 1]}", $"{board[0, 2]}"},
            //    { $"{board[1, 0]}", $"{board[1, 1]}", $"{board[1, 2]}" },
            //    { $"{board[2, 0]}", $"{board[2, 1]}", $"{board[2, 2]}" }
            //};

            for (int i = 0; i < board_colored.GetLength(0); i++) {
                for (int j = 0; j < board_colored.GetLength(1); j++) {
                    if (board[i,j] == "X") {
                        board_colored[i, j] = $"{Color.Blue}{board[i, j]}{Color.Rst}";
                    } 
                    else if (board[i, j] == "O") {
                        board_colored[i, j] = $"{Color.Green}{board[i, j]}{Color.Rst}";
                    }
                    else {
                        board_colored[i, j] = $"{board[i, j]}";
                    }
                }
            }

            return board_colored;
        }

        private string generateBoradString(string[,] board) {
            string[,] b = board;

            string output ="";
            output += string.Format(" {0} | {1} | {2} \n", " ", " ", " ");
            output += string.Format(" {0} | {1} | {2} \n", b[0,0], b[0, 1], b[0,2]);
            output += string.Format("---|---|---\n");
            output += string.Format(" {0} | {1} | {2} \n", b[1,0], b[1, 1], b[1,2]);
            output += string.Format("---|---|---\n");
            output += string.Format(" {0} | {1} | {2} \n", b[2,0], b[2, 1], b[2,2]);
            output += string.Format(" {0} | {1} | {2} \n", " ", " ", " ");

            return output;
        }

        public void ShowBoard() {
            string[,] coloredBoard = colorBord(this.board);
            Console.Write(generateBoradString(coloredBoard));
        }
    }
}
