using AbstractFactory.UI.Buttons;
using AbstractFactory.UI.Checkboxes;

namespace AbstractFactory.UI.Factories;

public interface IUIFactory
{
    public IButton CreateButton();
    public ICheckBox CreateCheckBox();
}
