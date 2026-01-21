using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands;

public class TurnLightOnCommand : ICommand
{
    private readonly Light _light;
    public TurnLightOnCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.On();
    }
    public void Undo()
    {
        _light.Off();
    }
}
