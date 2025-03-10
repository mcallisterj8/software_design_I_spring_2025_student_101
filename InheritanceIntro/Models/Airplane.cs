public class Airplane : Vehicle {

    public Airplane() {
        Console.WriteLine("Airplane constructor!");
    }

    public string Test() {
        return $"Example: {this.Manufacturer}";
    }

}