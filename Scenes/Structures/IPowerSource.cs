using Godot;
using ProjectManufactory.Scenes.Components;
using System;

namespace ProjectManufactory.Scenes.Structures;

public interface IPowerSource
{
	PowerSourceComponent PowerSourceComponent { get; }
}
