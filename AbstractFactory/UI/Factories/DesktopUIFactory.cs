using AbstractFactory.UI.Buttons;
using AbstractFactory.UI.Checkboxes;

namespace AbstractFactory.UI.Factories;

internal class DesktopUIFactory : IUIFactory
{
    public IButton CreateButton() =>  new DesktopButton();
    public ICheckBox CreateCheckBox() => new DesktopCheckBox();

}
