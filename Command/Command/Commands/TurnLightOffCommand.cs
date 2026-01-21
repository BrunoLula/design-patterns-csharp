using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands;

public class TurnLightOffCommand : ICommand
{
    private readonly Light _light;
    public TurnLightOffCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.Off();
    }
    public void Undo()
    {
        _light.On();
    }
}
