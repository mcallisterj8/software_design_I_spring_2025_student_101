public class ElectricCar : Automobile {

    public ElectricCar(string licensePlate, int seatCap) 
        : base(licensePlate, seatCap, true) {
        Console.WriteLine("ElectricCar constructor!");
    }

    public override string ToString() {
        return $"Name: {this.Name} | License Plate: {this.LicensePlate}";
    }

}