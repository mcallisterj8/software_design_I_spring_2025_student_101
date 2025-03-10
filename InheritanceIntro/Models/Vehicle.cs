public class Vehicle {
    public string Name { get; set; } = "Default Name";
    public int ModelYear { get; set; } = 2025;
    protected string Manufacturer { get; set; } = "Default Manufacturer";

    public Vehicle() {
        Console.WriteLine("Vehicle constructor!");
    }

    private void MaintenanceCheck() {
        Console.WriteLine("Performing maintenance check.");
    }

    protected void DisplayManufacturer() {
        Console.WriteLine($"Manufacturer: {this.Manufacturer}.");
    }

}