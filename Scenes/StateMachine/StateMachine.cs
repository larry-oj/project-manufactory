using Godot;

namespace ProjectManufactory.Scenes.StateMachine;

public partial class StateMachine : Node
{
	[Export] 
	private State _initialState;
	private State _currentState;

	public void Init(Node2D parent)
	{
		foreach (var child in GetChildren())
		{
			if (child is not State state) continue;
            
			state.Transitioned += OnChildTransition;
			state.Init(parent);
		}
        
		_currentState = _initialState;
		_currentState.Enter();
	}

	public void Shutdown()
	{
		foreach (var child in GetChildren())
		{
			if (child is not State state) continue;
			state.Transitioned -= OnChildTransition;
		}
        
		_currentState?.Exit();
		_currentState = null;
	}

	public void Process(double delta)
	{
		_currentState?.Process(delta);
	}
    
	public void PhysicsProcess(double delta)
	{
		_currentState?.PhysicsProcess(delta);
	}
    
	private void OnChildTransition(State state, State newState)
	{
		if (state != _currentState) return;
		if (newState == null) return;

		_currentState?.Exit();
		_currentState = newState;
		_currentState.Enter();
	}
}