
using System;
using System.Collections.Generic;
public class Room
    {
        public string Name;
        public string Description;
        public List<Item> Items = new List<Item>();
        public Dictionary<string, string> Exits = new Dictionary<string, string>();
    // lagrar information 
        public Room(string name, string description, List<Item> items)
        {
            Name = name;
            Description = description;
            Items = items;
        }
    }
