using System;

namespace Hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet GreekStyle = new Buffet();
            Ninja Kostas = new Ninja();
            while(Kostas.IsFull == false)
            {
                Kostas.Eat(GreekStyle.Serve());
            }
        }
    }
}
