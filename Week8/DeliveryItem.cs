namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber;
    public double Weight;
    
    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number {TrackingNumber}: {Weight}kg");
    }
}