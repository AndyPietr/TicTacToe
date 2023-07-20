using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace TicTacToe {
    internal class Game {
        private Board board;
        private InGameInfo inGameInfo;
        private GameState state;

        private readonly Dictionary<ConsoleKey, int> keyBinding = new Dictionary<ConsoleKey, int> {
            {ConsoleKey.D1, 1}, 
            {ConsoleKey.D2, 2}, 
            {ConsoleKey.D3, 3}, 
            {ConsoleKey.D4, 4},
            {ConsoleKey.D5, 5},
            {ConsoleKey.D6, 6},
            {ConsoleKey.D7, 7},
            {ConsoleKey.D8, 8},
            {ConsoleKey.D9, 9},

            {ConsoleKey.Q, 1},
            {ConsoleKey.W, 2},
            {ConsoleKey.E, 3},
            {ConsoleKey.A, 4},
            {ConsoleKey.S, 5},
            {ConsoleKey.D, 6},
            {ConsoleKey.Z, 7},
            {ConsoleKey.X, 8},
            {ConsoleKey.C, 9},
        };

        public Game() {
            state = GameState.MainMenu;
        }

        enum GameState {
            Playing,
            MainMenu,
            GameOver
        }

        

        public class InGameInfo {
            public int round;
            public InGameInfo()
            {
                this.round = 0;
            }
        }

        public void MainLoop() {

            while (true) {

                if (this.state == GameState.MainMenu) {
                    Console.Clear();

                    _print_welcome_screen();
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.Escape) {
                        _print_goodbye_screen();
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.O) {
                        Console.Write("\nshowing options to option screen\n");
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter) {
                        Console.Write("\nStarting new Game\n");
                        this.board= new Board();
                        this.inGameInfo = new InGameInfo();
                        this.state= GameState.Playing;
                    }
                }
                else if (this.state==GameState.Playing) {
                    Console.Clear();
                    Console.Write($"\n\nGame state: {this.state}\n\n");
                    // Show board
                    this.board.ShowBoard();
                    // Check Game Result
                    GameResult gr= this.board.GetGameResult();
                    
                    if (gr == GameResult.NoVictory) {
                        // Keep playing
                    }
                    else {
                        // Finish game
                        this.state = GameState.GameOver;
                    }

                    // Show game state info (ex. "round 1, you play as X, select field 1-9"s)
                    Console.Write($"\n\nGame state: {this.state} round: {this.inGameInfo.round}\n\n");


                    // Wait for User Input
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    // if input is 1-9 or q-c then update board
                    if (keyBinding.ContainsKey(keyInfo.Key)) {
                        this.board.UpdateBoard("X", keyBinding[keyInfo.Key]);
                    }


                }
                else if (this.state == GameState.GameOver) {
                    // Show game over screen
                    // TODO game over screen
                    Console.WriteLine("\n\nGAme over screen\n\n");
                }
            }
        }

        private void _print_goodbye_screen() {
            string goodbye_screen = "";
            goodbye_screen += "\n\t TThanks for playing. Ciao!\n";
            Console.Write(goodbye_screen);
        }

        private void _print_welcome_screen() {
            string welcome_screen = "";
            welcome_screen += "\tWelcome to Tic Tac Toe Game\n\n";
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", " ", " ", " ");
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", 1, 2, 3);
            welcome_screen += string.Format("\t---|---|---\n");
            welcome_screen += string.Format("\t {0} | {1} | {2} \n", 4, 5, 6);
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
