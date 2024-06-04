using Godot;
using ProjectManufactory.Scenes.Components;
using ProjectManufactory.Scenes.StateMachine;
using System;

namespace ProjectManufactory.Scenes.Structures.Generator;

public partial class Generator : Structure, IPowerSource
{
    public PowerSourceComponent PowerSourceComponent { get; private set; }

    public override void _Ready()
    {
        // init state machine
        base._Ready();

        PowerSourceComponent = GetNode<PowerSourceComponent>("PowerSourceComponent");
    }
}
