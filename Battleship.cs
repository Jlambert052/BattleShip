namespace Game {
    public class Battleship {
        char water = '~';
        char ship = 'S';
        char hit = 'X';
        char miss = 'O';

        char[] tug = new char[] {'S','S'};
        char[] battleship = new char[] {'S','S', 'S'};
        char[] cruiser = new char[] {'S','S', 'S', 'S'};
        char[] carrier = new char[] {'S','S', 'S', 'S', 'S'};

        char[] columnNames = new char[] {'+', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        char[] rowNames = new char[] {'+', '1', '2', '3', '4', '5', '6', '7', '8'};

        static int[,] ints = new int[8, 8];
        static int[,] board = new int[9, 9];

        public void  DisplayInts(int[,] ints) {
            for(int i = 0; i < ints.GetLength(0); i++) {

                for(int j = 0; j < ints.GetLength(1); j++) {
                    Console.Write($"{ints[i, j]} | ");
                }
                System.Console.WriteLine();
            }
        }

        public void SetupBoard(char[,] board) {
            System.Console.WriteLine("Here's your board. Place your ships carefully.");

            for(int i = 0; i < board.GetLength(0); i++) {

                for(int j = 0; j < board.GetLength(1); j++) {
                    if(i == 0) {
                        board[i,j] = columnNames[j];
                        if(i == 0 && j == 0) {}
                        else
                        System.Console.Write($"{columnNames[j], 4}");
                        
                    }if(j == 0) {
                        board[i,j] = rowNames[i];
                        System.Console.Write($" {rowNames[i], 5}");
                    }if(i > 0 && j > 0) {

                        board[i,j] = water;
                        if(j == 1) {
                        System.Console.Write($" |{board[i,j], 2} ");
                        } else
                        System.Console.Write($"|{board[i,j], 2} ");
                        if(j == board.GetLength(0) - 1) {
                            System.Console.Write("|");
                        }      
                    }
                }
                System.Console.WriteLine();
            }
        }

        public void PlaceShip(char[] ship) { 
            System.Console.WriteLine("Which ship would you like to place?");
            System.Console.WriteLine("Enter 'tug' (2 squares), 'battleship' (3 squares), 'cruiser' (4 squares), or 'carrier' (5 squares) ");
            string playerEntry = Console.ReadLine();
            playerEntry.ToLower();
            while(playerEntry != "battleship" || playerEntry != "tug" || playerEntry != "crusier" || playerEntry != "carrier") {
                System.Console.WriteLine("That is not a valid ship! Re-enter your selection; 'tug', 'battleship', 'cruiser' or 'carrier'");
                playerEntry = Console.ReadLine();
            }

            System.Console.WriteLine("Where would you like to place this ship? Enter the first and last coordinate the ship occupies. Rows are A-H; Columns are 1-8. ");



        }
        public void CheckPlacedShips(char[,] board) {

        }

        //public int BattleShip(int[,] field) {
            
        //}
    }
}