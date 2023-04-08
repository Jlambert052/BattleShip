namespace Game {
    public class Ship {
        public string Name {get; set; }
        public bool Placed {get; set;}
        public bool Destroyed {get; set;}
        
        public List<string[]> ?Coordinates {get; set;}

        public Ship(string aName, bool aPlaced, bool aDestroyed) {
            Name = aName;
            Placed = aPlaced;
            Destroyed = aDestroyed;
        }
    }
}