using Godot;
using System;

namespace ProjectManufactory.Scenes.Components;

/// <summary>
/// Represents a power source.
/// </summary>
public partial class PowerSourceComponent : Node
{
	[Export] public float MaxOutput { get; set; }
	[Export] public bool IsActive { get; set; }

	private EventBus _eventBus;

	[Signal] public delegate void GeneratedEventHandler(float amount);

    public override void _Ready()
    {
		_eventBus = GetNode<EventBus>(Options.Path.EventBus);
    }
}
