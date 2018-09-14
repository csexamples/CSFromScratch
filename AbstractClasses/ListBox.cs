using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    public class ListBox : Control
    {
        public ListBox(int xPos, int yPos, List<string> contents) : base(xPos, yPos)
        {
            list = contents;
        }

        private List<string> list = new List<string>();

        public override void Draw()
        {
            Console.WriteLine("Listbox drawing");
        }
    }
}
