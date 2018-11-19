class OrderService
{
    void FinalizeOrder(Order order)
    {
        Printer printer = new Printer(order);
        printer.PrintReceipt(order.Items.Count < 10);
    }
}

class Printer
{
    private Order _order;

    public Printer(Order order)
    {
        _order = order;
    }
    void PrintReceipt(bool printDetails)
    {
        foreach (Item item in _order.Items)
        {
            PrintLine(item.Name);
            if (printDetails)
            {
                PrintLine(item.Description);
            }
        }
    }
}