using Godot;

public partial class BaseCharacter : CharacterBody2D {
	[Signal]
	public delegate void DirectionChangedEventHandler(Vector2 diretcion);

	public Vector2 Direction {
		get { return _direction; }
		set {
			if (_direction == value)
				return;

			_direction = value;
			EmitSignal(SignalName.DirectionChanged, _direction);
		}
	}
	private Vector2 _direction;

}
