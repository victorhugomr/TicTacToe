using TicTacToe.Services;
using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe{

    public class Program{

        static void Main(string[] args){

            NewGame newGame = new NewGame();
            newGame.Start();
        }
    }
}