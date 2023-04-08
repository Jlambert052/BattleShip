namespace Game {


    public class FB {
List<int> Ints = new List<int> {1, 2, 3, 4, 5, 10, 15, 20, 23, 27, 33};
        public int FizzBuzz(List<Int32> Ints) {
            for(int i = 0; i < Ints.Count(); i++) {
                if(Ints[i] % 2 == 0 && Ints[i] % 3 == 0) {
                    System.Console.WriteLine("Fizzbuzz");
                } else if (Ints[i] % 2 == 0) {
                    System.Console.WriteLine("Fizz");
                } else if (Ints[i] % 3 == 0 ) {
                    System.Console.WriteLine("Buzz");
                } else {
                    System.Console.WriteLine($"{Ints[i]}");
                    } 
            }
            return 0;
        }

    }
}