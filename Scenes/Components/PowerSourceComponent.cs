using Godot;
using System;

namespace ProjectManufactory.Scenes.Components;

/// <summary>
/// Represents a power source.
/// </summary>
public partial class PowerSourceComponent : Node
{
	[Export] public float GenerationPerMinute { get; set; }
	[Export] public bool IsActive { get; set; }

	private EventBus _eventBus;

	[Signal] public delegate void GeneratedEventHandler(float amount);

    public override void _Ready()
    {
		_eventBus = GetNode<EventBus>(Options.Path.EventBus);

		_eventBus.PowerTickElapsed += () =>
		{
			if (!IsActive) return;
			var amount = GenerationPerMinute / 60 / Options.Game.PowerTickRate;
			EmitSignal(PowerSourceComponent.SignalName.Generated, amount);
		};
    }
}
