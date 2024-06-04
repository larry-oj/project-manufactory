using Godot;
using ProjectManufactory;
using ProjectManufactory.Scenes;
using System;

namespace ProjectManufactory.Scenes.Components;

public partial class PowerConsumerComponent : Node
{
	private EventBus _eventBus;

	public override void _Ready()
	{
		_eventBus = GetNode<EventBus>(Options.Path.EventBus);
	}
}
