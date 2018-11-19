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
    private List<ItemPrinter> _printers { get; set; }
    private Order _order { get; set; }

    Printer(Order order)
    {
        _order = order;
        _printers = new List<Printer>();
        _printers.add(new NamePrinter());
    }

    void EnablePrintingDescriptions()
    {
        _printers.Add(new DescriptionPrinter());
    }

    void EnablePrintingTaxes()
    {
        _printers.Add(new TaxPrinter());
    }

    void EnablePrintingQuantity()
    {
        _printers.Add(new QuantityPrinter());
    }

    void PrintReceipt()
    {
        foreach (Item item in _order)
        {
            foreach (ItemPrinter printer in _printers)
            {
                PrintLine(printer.Format(item));
            }
        }
    }

    private PrintLine(String line)
    {
        // implementation for printing to a physical printer
    }
}

interface ItemPrinter
{
    String Format(Item item);
}

class NamePrinter : ItemPrinter
{
    String Format(Item item)
    {
        return Item.Name;
    }
}

class DescriptionPrinter : ItemPrinter
{
    String Format(Item item)
    {
        return Item.Description;
    }
}

class TaxPrinter : ItemPrinter
{
    String Format(Item item)
    {
        return Item.Tax;
    }
}

class QuantityPrinter : ItemPrinter
{
    String Format(Item item)
    {
        return Item.Quantity;
    }
}