namespace TicTacToe.Models{

    public class Board{
        
        public char[] position { get; set; } = null!;

        public Board(){
            position = new []{
                '1', '2', '3',
                '4', '5', '6',
                '7', '8', '9'};
        }
    }
}