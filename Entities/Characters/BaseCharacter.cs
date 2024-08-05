using Godot;

public partial class BaseCharacter : CharacterBody2D {
	[Signal]
	public delegate void DirectionChangedEventHandler(Vector2 diretcion);

	[Export(PropertyHint.Range, "0,200,1,or_greater")]
	public int MoveSpeed { get; set; } = 120;

	[Export(PropertyHint.Range, "0,500,1,or_greater")]
	public int GroundJumpForce { get; set; } = 350;

	[Export]
	public bool CanGroundJump { get; set; } = false;

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

	// Makes the player character jump if possible
	//
	// Returns true if jump is successful or false if it is not
	public bool Jump() {
		if (IsOnFloor() && CanGroundJump) {
			_executeGroundJump();
			return true;
		}

		return false;
	}

	protected void _applyGravity(double delta) {
		var gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

		var velocity = Velocity;
		velocity.X += gravity * (float)delta;
		velocity.Y += gravity * (float)delta;
		Velocity = velocity;
	}

	// Executes a ground jump
	protected void _executeGroundJump() {
		var velocity = Velocity;
		velocity.Y -= GroundJumpForce;
		Velocity = velocity;
	}
}
