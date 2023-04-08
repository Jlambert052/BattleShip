// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to BATTLESHIP. Place your ships well and fire at will!");

Game.Battleship Ship = new();

int[,] ints = new int[8,5] { {1, 2, 3, 4, 5}, {2, 3, 4, 5, 6}, {3, 4, 5, 6, 7}, {4, 5, 6, 7, 8}, {5, 6, 7, 8, 9}, {6, 7, 8, 9, 10}, {7, 8, 9, 10, 11}, {8, 9, 10, 11, 12} };
char[,] board = new char[9,9];
        char[] columnNames = new char[] {'+', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        char[] rowNames = new char[] {'+', '1', '2', '3', '4', '5', '6', '7', '8'};

List<int> List = new List<int> {1, 2, 3, 6, 9, 15, 20, 23, 27, 30, 100};

//Ship.DisplayInts(ints);

//Ship.SetupBoard(board);

//Ship.BoardCoord(columnNames, rowNames);

//Ship.PlaceShip();


Game.FB FizzBuzz = new(); 

FizzBuzz.FizzBuzz(List);
