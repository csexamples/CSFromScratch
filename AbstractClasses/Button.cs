using System;

namespace AbstractClasses
{
    public class Button : Control
    {
        public Button(int xPos, int yPos, string text) : base(xPos, yPos)
        {
            this.text = text;
        }

        private string text;

        public override void Draw()
        {
            Console.WriteLine("Drawing Button");
        }
    }
}
