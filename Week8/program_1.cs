namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("69T839Q", 0.1);
        Letter letter2 = new Letter("59T939W", 0.2);
        Parcel parcel1 = new Parcel("5WG89V9", 2, "20x30");
        Parcel parcel2 = new Parcel("7TG85L9", 3, "30x30");
        letter1.PrintInfo();
        parcel2.PrintInfo();
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        myCargo.AddItem(letter2);
        Console.WriteLine($"Total cost is: {myCargo.GetTotalCost()}");

    }
}