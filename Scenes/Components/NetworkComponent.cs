using Godot;
using ProjectManufactory.Scenes.Structures;
using System;

namespace ProjectManufactory.Scenes.Components;

public partial class NetworkComponent : Area2D
{
	public Network Network { get; private set; }

	public override void _Ready()
	{
		Network.Register(Owner as INetworked);
		AreaEntered += OnAreaEntered;
	}

	public override void _ExitTree()
	{
		Network.Unregister(Owner as INetworked);
		AreaEntered -= OnAreaEntered;
	}

	private void OnAreaEntered(Node area)
	{
		if (area.Owner is not INetworked networked) return;
		
		var areaNetwork = networked.NetworkComponent.Network;

		if (areaNetwork == Network) return;
		
		if (areaNetwork.Participants.Count > this.Network.Participants.Count)
		{
			Network.MigrateAll(areaNetwork);
			Network = areaNetwork;
		}
		else
		{
			areaNetwork.MigrateAll(Network);
			networked.NetworkComponent.Network = Network;
		}
	}
}
