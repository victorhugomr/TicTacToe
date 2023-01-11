using TicTacToe.Models;

namespace TicTacToe.Views{

    public class View{

        private void showMenu(){
            
        }

        public void showBoard(Board board){
            Console.Clear();
            Console.WriteLine($"{board.position[0]} {board.position[1]} {board.position[2]}");
            Console.WriteLine($"{board.position[3]} {board.position[4]} {board.position[5]}");
            Console.WriteLine($"{board.position[6]} {board.position[7]} {board.position[8]}");
        }

        public void choosePositionScreen(){
            Console.WriteLine($"\nVEZ DO \"jogador\": Em qual posição deseja jogar?");
        }

        public void victoryScreen(){
            Console.WriteLine("\nFim de jogo (vitória).");
        }

        public void drawScreen(){
            Console.WriteLine("\nFim de jogo (empate).");
        }
    }
}