public void DoStuff()
{
    if (SetAttribute("username", "Renato"))
    {
        Console.WriteLine("Everything is fine! :-)");
    }
    else
    {
        Console.WriteLine("Something is wrong! :-(");
    }
}

public bool SetAttribute(string attribute, string value)
{
    if(!_properties.ContainsKey(attribute))
    {
        return false;
    }

    _properties[attribute] = value;

    return true;
}