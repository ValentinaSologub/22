
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        address.index = "12345";
        address.country = "Ukraine";
        address.city = "Kyiv";
        address.street = "Kreshchatyk";
        address.house = "14";
        address.apartment = "25";

        Console.WriteLine(address);
    }
}