public void DoStuff()
{
    var attributeName = "username";
    if (AttributeExists(attributeName))
    {
        SetAttribute(attributeName, "Renato");
        Console.WriteLine("Everything is fine! :-)");
    }
    else
    {
        Console.WriteLine("Something is wrong! :-(");
    }
}

public bool AttributeExists()
{
    return _properties.ContainsKey(attribute);
}

public bool SetAttribute(string attribute, string value)
{
    _properties[attribute] = value;
}
