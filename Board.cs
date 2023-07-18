using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    internal class Board {
        private char[,] fields;

        public Board()
        {
            this.fields = new char[,]{
                {'1', '2', '3'},
                {'4', '5', '6' },
                {'7', '8', '9' }
            };
        }

        private string generateBoradString(char[,] board) {
            string output="";
            output += string.Format(" {0} | {1} | {2} \n", " ", " ", " ");
            output += string.Format(" {0} | {1} | {2} \n", board[0,0], board[0, 1], board[0,2]);
            output += string.Format("---|---|---\n");
            output += string.Format(" {0} | {1} | {2} \n", board[1,0], board[1, 1], board[1,2]);
            output += string.Format("---|---|---\n");
            output += string.Format(" {0} | {1} | {2} \n", board[2,0], board[2, 1], board[2,2]);
            output += string.Format(" {0} | {1} | {2} \n", " ", " ", " ");

            return output;
        }

        public void ShowBoard() {
            Console.Write(generateBoradString(this.fields));
        }
    }
}
