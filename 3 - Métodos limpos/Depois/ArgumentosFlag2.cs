class OrderService
{
    void FinalizeOrder(Order order)
    {
        Printer printer = new Printer(order);
        if(order.Items.Count < 10)
        {
            printer.PrintReceiptWithDescription();
        }
        else
        {
            printer.PrintReceiptNoDescription();
        }
    }
}

class Printer
{
    private Order _order;

    public Printer(Order order)
    {
        _order = order;
    }
    void PrintReceiptWithDescription()
    {
        foreach (Item item in _order.Items)
        {
            PrintLine(item.Name);
            PrintLine(item.Description);            
        }
    }

    void PrintReceiptNoDescription()
    {
        foreach (Item item in _order.Items)
        {
            PrintLine(item.Name);            
        }
    }
}