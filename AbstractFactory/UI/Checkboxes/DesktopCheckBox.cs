using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UI.Checkboxes;

internal class DesktopCheckBox : ICheckBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a desktop checkbox: ");
    }
}
