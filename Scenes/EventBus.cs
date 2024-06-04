using Godot;

namespace ProjectManufactory.Scenes;

/// <summary>
/// Event bus singleton pattern, see https://www.gdquest.com/tutorial/godot/design-patterns/event-bus-singleton/
/// </summary>
public partial class EventBus : Node
{
    [Signal] public delegate void PowerTickElapsedEventHandler();
}