using System;
using System.Collections.Generic;

class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            if(calorieIntake > 1200)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
    
    // build out the Eat method
    public void Eat(Food item)
    {
        if(IsFull == false)
        {
            calorieIntake = calorieIntake + item.Calories;
            Console.WriteLine($"This {item.Name} is the best");
        }else
        {
            Console.WriteLine("ninja is full and connot eat anymore");
        }
    }
}

