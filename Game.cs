using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    internal class Game {

        public Game()
        {
            Board board = new Board();
        }
        internal void MainLoop() {

            while (true) {
                _print_welcome_screen();
                ConsoleKeyInfo keyInfo= Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape) {
                    _print_goodbye_screen();
                    break;
                }
            }
        }

        private void _print_goodbye_screen() {
            string goodbye_screen = "";
            goodbye_screen += "\n\t TThanks for playing. Ciao!\n";
            Console.Write(goodbye_screen);
        }

        private void _print_welcome_screen() {
            string welcome_screen="";
            welcome_screen += "\tWelcome to Tic Tac Toe Game\n\n";
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", " ", " ", " ");
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", 1, 2, 3);
            welcome_screen += string.Format("\t---|---|---\n");
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", 4,5, 6);
            welcome_screen += string.Format("\t---|---|---\n");
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", 7, 8, 9);
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", " ", " ", " ");

            welcome_screen += string.Format("\n-> Press [Enter] for Quick Play  \n");
            welcome_screen += string.Format("-> Press [Esc] to Quit  \n");
            welcome_screen += string.Format("-> Press [o] for Options  \n");


            Console.Write(welcome_screen);
        }
    }
}
