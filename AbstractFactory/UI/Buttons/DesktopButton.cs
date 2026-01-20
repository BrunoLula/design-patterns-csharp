using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UI.Buttons;

internal class DesktopButton : IButton
{
    public string color => "Gray";
    public void Render()
    {
        Console.WriteLine("Rendering a desktop button with color: " + color);
    }
}
