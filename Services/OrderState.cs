using bookstore.Models;
namespace bookstore.Services;

public class OrderState
{
  public Order Order { get; set; } = new();

  public event Action OnChange;

  public OrderState()
  {
    Order.OrderItems = new List<OrderItem>();
  }

  public void AddItem(OrderItem item) // add book to cart
  {
    Order.OrderItems.Add(item);
    OnChange?.Invoke();
  }

  public void RemoveItem(OrderItem item) // remove book to cart
  {
    Order.OrderItems.Remove(item);
  }

  public void ResetOrder() // after placing an order
  {
    Order = new Order();
  }
}