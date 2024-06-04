using Godot;
using ProjectManufactory.Scenes.Structures;
using ProjectManufactory.Scenes.Components;
using System;

namespace ProjectManufactory.Scenes.Components.PowerCell;

public partial class PowerCell : Structure, IPowerConsumer, IPowerCapacitor, IPowerSource
{
	public PowerConsumerComponent PowerConsumerComponent { get; private set; }
    public PowerCapacitorComponent PowerCapacitorComponent { get; private set; }
	public PowerSourceComponent PowerSourceComponent { get; private set; }

    public override void _Ready()
	{
		base._Ready();

		PowerConsumerComponent = GetNode<PowerConsumerComponent>("PowerConsumerComponent");
		PowerCapacitorComponent = GetNode<PowerCapacitorComponent>("PowerCapacitorComponent");
		PowerSourceComponent = GetNode<PowerSourceComponent>("PowerSourceComponent");
	}
}
