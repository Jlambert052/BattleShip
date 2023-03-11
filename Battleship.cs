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

        string[] boardCoords = new string[64];

        public string[] BoardCoord(char[] rows, char[] columns) {
            int m = 0;
            for(int i = 1; i < columnNames.Length; i++) {

                for(int j = 1; j < rowNames.Length; j++) {
                    boardCoords[m] = columnNames[i].ToString()+rowNames[j].ToString();
                    //Console.Write($" {boardCoords[m]} ");
                }
                //System.Console.WriteLine();
            }
            return boardCoords;
        }
    
        static int[,] ints = new int[8, 8];
        static int[,] board = new int[9, 9];

        public void  DisplayInts(int[,] ints) {             //example format to show the nested for loop.
            for(int i = 0; i < ints.GetLength(0); i++) {

                for(int j = 0; j < ints.GetLength(1); j++) {
                    Console.Write($"{ints[i, j]} | ");
                }
                System.Console.WriteLine();
            }
        }

        public void SetupBoard(char[,] board) {
            System.Console.WriteLine("Here's your board. Place your ships carefully.");
            //nested for loop iterates through the game board 2d array
            for(int i = 0; i < board.GetLength(0); i++) {

                for(int j = 0; j < board.GetLength(1); j++) {
                    if(i == 0) {                                    //interior array setup so that the "0" row shows labels for columns
                        board[i,j] = columnNames[j];                //the 0,0 spot is marked with a +
                        if(i == 0 && j == 0) {}
                        else
                        System.Console.Write($"{columnNames[j], 4}");
                        
                    }if(j == 0) {
                        board[i,j] = rowNames[i];
                        System.Console.Write($" {rowNames[i], 5}");     //if statement covers the 0 column shows row names
                    }if(i > 0 && j > 0) {

                        board[i,j] = water;                             //assigns the board space to have the water variable for later checking by the shooting method or placement method
                        if(j == 1) {
                        System.Console.Write($" |{board[i,j], 2} ");       //small adjustment to make sure the spacing is accurate.
                        } else
                        System.Console.Write($"|{board[i,j], 2} ");     //Prints out the board space into the console.
                        if(j == board.GetLength(0) - 1) {
                            System.Console.Write("|");                  //closes the end of the row for nicer appearance.
                        }      
                    }
                }
                System.Console.WriteLine();
            }
        }

        //function to request the player to place a ship in the board; stating the sizes of each ship. 
        public void PlaceShip() { 

            var Ships = new [] {"tug","battleship","crusier","carrier"};
            bool Entry = true;
            System.Console.WriteLine("Which ship would you like to place?");
            System.Console.WriteLine("Enter 'tug' (2 squares), 'battleship' (3 squares), 'cruiser' (4 squares), or 'carrier' (5 squares) ");
            string playerEntry = Console.ReadLine();
            playerEntry.ToLower();
            if(playerEntry.Contains(Ships[0]) || playerEntry.Contains(Ships[1]) || playerEntry.Contains(Ships[2]) || playerEntry.Contains(Ships[3]) ) {
                Entry = false;
            }
            //while loop to make sure that they use a functional ship name. 
            while(Entry) {
                
                System.Console.WriteLine("That is not a valid ship! Re-enter your selection; 'tug', 'battleship', 'cruiser' or 'carrier'");
                playerEntry.ToLower();
                if(playerEntry.Contains(Ships[0]) || playerEntry.Contains(Ships[1]) || playerEntry.Contains(Ships[2]) || playerEntry.Contains(Ships[3]) ) {
                Entry = false;
                }
            }
            System.Console.WriteLine("Where would you like to place this ship? Enter the first square the ship occupies. Rows are A-H; Columns are 1-8. Example => A1");
            string playerPlace = Console.ReadLine();
            playerPlace.ToUpper();
            string[] coords = BoardCoord(rowNames, columnNames);
            coords.SingleOrDefault(playerPlace);

        }
        //repeatable function to make sure that the ships are placed in an eligible location.
        public void CheckPlacedShips(char[,] board) {

        }

        //public int BattleShip(int[,] field) {
            
        //}
    }
}