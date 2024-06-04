using Godot;

namespace ProjectManufactory.Scenes.StateMachine;

public partial class State : Node
{
	[Signal] public delegate void TransitionedEventHandler(State state, State newState);
    
	protected Node2D Parent;
	protected EventBus EventBus;

	public void Init(Node2D parent, EventBus eventBus)
	{
		Parent = parent;
		EventBus = eventBus;
	}

	public virtual void Enter() {}
	public virtual void Exit() {}
	public virtual void Process(double delta) {}
	public virtual void PhysicsProcess(double delta) {}
}