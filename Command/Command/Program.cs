using Command.Commands;
using Command.Invokers;
using Command.Receivers;

class Program
{
    static void Main()
    {
        var light = new Light();
        var remote = new RemoteControl();

        var lightOn = new TurnLightOnCommand(light);
        var lightOff = new TurnLightOffCommand(light);

        remote.SetCommand(lightOn);
        remote.PressButton();

        remote.PressUndo();

        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}
