public class Automobile : Vehicle {
    public string LicensePlate { get; set; }
    public int SeatingCapacity { get; set; }
    public bool IsElectric { get; set; }


    public Automobile(string licensePlate, int seatCap, bool isElectric) {
        Console.WriteLine("Automobile constructor!");
        this.LicensePlate = licensePlate;
        this.SeatingCapacity = seatCap;
        this.IsElectric = isElectric;
    }

}