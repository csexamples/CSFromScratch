using System;

namespace AbstractClasses
{
    public abstract class Control
    {
        protected Control(int xPosition, int yPosition)
        {
            xPos = xPosition;
            yPos = yPosition;
        }

        protected int xPos;
        protected int yPos;

        public virtual void Clear()
        {
            Console.WriteLine("Clearing control");
        }

        public abstract void Draw();
    }
}
