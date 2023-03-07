namespace Game {
    public class Battleship {
        char water = '~';
        char ship = 'S';
        char hit = 'X';
        char miss = 'O';

        static int[,] ints = new int[8, 8];
        static int[,] board = new int[8, 8];

        public void  DisplayInts(int[,] ints) {
            for(int i = 0; i < ints.GetLength(0); i++) {

                for(int j = 0; j < ints.GetLength(1); j++) {
                    Console.Write($"{ints[i, j]} | ");
                }
                System.Console.WriteLine();
            }
        }

        public void AssignBoard(char[,] board) {
            for(int i = 0; i < board.GetLength(0); i++) {

                for(int j = 0; j < board.GetLength(1); j++) {
                    board[i,j] = water;
                    System.Console.Write($"| {board[i,j]} ");
                    if(j == 7) {
                        System.Console.Write("|");
                    }      
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("Here's your board. Place your ships carefully.");
        }

        //public int BattleShip(int[,] field) {
            
        //}
    }
}