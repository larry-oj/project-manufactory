using Godot;
using System;
using ProjectManufactory.Scenes.StateMachine;

namespace ProjectManufactory.Scenes.Structures.Generator;

public partial class Inactive : State
{
	public override void Enter()
	{
		var parent = Parent as Generator;
		parent.PowerSourceComponent.IsActive = false;
	}
}

