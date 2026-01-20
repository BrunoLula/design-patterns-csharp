using AbstractFactory.UI.Buttons;
using AbstractFactory.UI.Checkboxes;

namespace AbstractFactory.UI.Factories;

internal class WebUIFactory : IUIFactory
{
    public IButton CreateButton() => new WebButton(); 
    public ICheckBox CreateCheckBox() => new WebCheckBox();

}
