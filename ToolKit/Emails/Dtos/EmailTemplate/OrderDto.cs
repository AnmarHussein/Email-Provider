namespace ToolKit.Emails.Dtos.EmailTemplate;
public class OrderDto
{
    public string FullName { get; set; }
    public string NameLink { get; set; }
    public string Link { get; set; }
    public List<OrderItem> Items { get; set; }
}

public class OrderItem
{
    public string ProductName { get; set; }
    public long Quantity { get; set; }
    public long Price { get; set; }
}
