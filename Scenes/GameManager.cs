using Godot;

namespace ProjectManufactory.Scenes;

public partial class GameManager : Node2D
{
    private Timer _powerTickTimer;
    private EventBus _eventBus;

    public override void _Ready()
    {
        _eventBus = GetNode<EventBus>(Options.Path.EventBus);

        // set up power ticks
        _powerTickTimer = GetNode<Timer>("%PowerTick");
        _powerTickTimer.WaitTime = Options.Game.PowerTickRate;
        _powerTickTimer.Timeout += () => _eventBus.EmitSignal(EventBus.SignalName.PowerTickElapsed);
        _powerTickTimer.Start();
    }
}