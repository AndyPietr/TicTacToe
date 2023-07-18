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


    }
}
