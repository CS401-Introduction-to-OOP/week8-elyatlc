namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items;

    public CargoContainer()
    {
        _items = new List<T>();
    }

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double total = 0; 
        foreach (T item in _items)
        {
            total += item.CalculateCost();
        }
        return total;
    }
}