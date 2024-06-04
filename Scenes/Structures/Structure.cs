using Godot;
using Godot.Collections;
using System;

namespace ProjectManufactory.Scenes.Structures;

public partial class Structure : StaticBody2D
{
	private StateMachine.StateMachine _stateMachine;

	public override void _Ready()
	{
		_stateMachine = GetNode<StateMachine.StateMachine>("StateMachine");

		_stateMachine.Init(this);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_stateMachine.Process(delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		_stateMachine.PhysicsProcess(delta);
	}
}
