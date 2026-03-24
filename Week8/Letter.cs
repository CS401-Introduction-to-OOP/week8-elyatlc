namespace Week8;

public class Letter: DeliveryItem
{
    public Letter(string name, int weight) : base(name, weight)
    {
    }

    public override double CalculateCost()
    {
        return 15 + (Weight * 10);
    }
}