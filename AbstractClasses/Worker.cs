using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            List<Control> controls = new List<Control>();
            Button button = new Button(0, 100, "Button text");
            ListBox listBox = new ListBox(100, 300, new List<string>());
            Button cancelButton = new Button(150, 100, "cancel");

            controls.Add(button);
            controls.Add(listBox);
            controls.Add(cancelButton);

            foreach(Control control in controls)
            {
                control.Draw();
            }
        }
    }
}
