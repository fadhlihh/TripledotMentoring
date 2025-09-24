public struct CarStruct
{
    public string Manufacture { get; private set; }
    public string Name { get; private set; }
    public string Color { get; private set; }
    public string LicensePlate { get; set; }

    public CarStruct(string manufacture, string name, string color, string licensePlate)
    {
        Manufacture = manufacture;
        Name = name;
        Color = color;
        LicensePlate = licensePlate;
    }
}
