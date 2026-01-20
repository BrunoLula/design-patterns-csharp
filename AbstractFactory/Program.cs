
using AbstractFactory.UI.Factories;

class Program
{
    static void Main()
    {
        IUIFactory factory = new WebUIFactory();

        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckBox();

        button.Render();
        checkbox.Render();
    }
}
