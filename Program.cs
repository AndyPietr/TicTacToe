﻿namespace TicTacToe {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            Board board = new Board();
            board.ShowBoard();
        }
    }
}