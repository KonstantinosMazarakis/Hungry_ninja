using System;
using System.Collections.Generic;

class Buffet
{
    public List<Food> Menu;
    
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("chocolate", 400, false, true),
            new Food("chicken", 900, false, false),
            new Food("coffee", 200, false, false),
            new Food("beef", 1400, false, false),
            new Food("tacos", 1900, true, false),
            new Food("cookies", 600, false, true),
            new Food("milk", 150, false, false)
        };
    }
    
    public Food Serve()
    {
        Random rand = new Random();
        int number = rand.Next(0,7);
        Console.WriteLine(this.Menu[number].Name);
        return this.Menu[number];
    }
}

