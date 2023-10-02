
class Program
{
    public static void Main()
    {
        Address address = new Address();
        address.Index = 456;
        address.City = "Kyiv";
        address.House = 456;
        address.Apartment = 456;
        address.Country = "Ukraine";

        Console.WriteLine(address);
    }
}