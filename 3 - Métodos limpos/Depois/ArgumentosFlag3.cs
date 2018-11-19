class OrderService
{
    void FinalizeOrder(Order order)
    {
        Printer printer = new Printer(order);

        if (order.Items.Count < 10)
        {
            printer.EnablePrintingDescriptions();
        }

        printer.EnablePrintingTaxes();
        printer.EnablePrintingQuantity();

        printer.PrintReceipt();
    }
}

class Printer
{
    private Order _order;
    private bool _printDescriptions;
    private bool _printQuantity;
    private bool _printTaxes;

    public Printer(Order order)
    {
        _order = order;
    }  
    
    void EnablePrintingDescriptions()
    {
        _printDescriptions = true;
    }

    void EnablePrintingTaxes()
    {
        printTaxes = true;
    }

    void EnablePrintingQuantity()
    {
        printQuantity = true;
    }

    void PrintReceipt()
    {
        foreach (Item item in _order)
        {
            PrintLine(item.Name);

            if (_printDescriptions)
            {
                PrintLine(item.Description);
            }

            if (_printQuantity)
            {
                PrintLine(item.Quantity);
            }

            if (_printTaxes)
            {
                PrintLine(item.TaxAmount);
            }
        }
    }
}