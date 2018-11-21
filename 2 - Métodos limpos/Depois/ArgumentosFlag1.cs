class OrderService
{
    void FinalizeOrder(Order order)
    {
        Printer printer = new Printer(order);
        var printDescriptions = order.Items.Count < 10;
        printer.PrintReceipt(printDescriptions);
    }
}

class Printer
{
    private Order _order;

    public Printer(Order order)
    {
        _order = order;
    }
    void PrintReceipt(bool printDescriptions)
    {
        foreach (Item item in _order.Items)
        {
            PrintLine(item.Name);
            if (printDescriptions)
            {
                PrintLine(item.Description);
            }
        }
    }
}