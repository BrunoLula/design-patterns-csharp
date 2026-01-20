using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UI.Buttons;

internal class WebButton : IButton
{
    public string color => "Blue";
    public void Render()
    {
        Console.WriteLine("Rendering a web button with color: " + color);
    }
}
