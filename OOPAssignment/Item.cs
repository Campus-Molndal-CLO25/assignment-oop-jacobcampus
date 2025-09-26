using System;
using System.Collections.Generic;
using System.Text;

public class Item
{
    public string Name { get; set; }
    public List<Item> Items = new List<Item>();
    public Item(string name, string description)
    {
        Name = name;


    }
}
