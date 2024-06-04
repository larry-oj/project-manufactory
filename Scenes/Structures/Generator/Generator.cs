using Godot;
using ProjectManufactory.Scenes.StateMachine;
using System;

namespace ProjectManufactory.Scenes.Structures.Generator;

public partial class Generator : StaticBody2D
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
