using Godot;
using System;

namespace ProjectManufactory.Scenes.Components;

public partial class PowerCapacitorComponent : Node
{
	[Export] public float MaximumCapacity { get; set; }

	private float _currentCapacity;
	public float CurrentCapacity 
	{
		get => _currentCapacity;
		set 
		{
			var before = _currentCapacity;
			var after = value;
			_currentCapacity = value;
			EmitSignal(PowerCapacitorComponent.SignalName.CapacityChanged, before, after);
		}
	}

	[Signal] public delegate void CapacityChangedEventHandler(float before, float after);
}
