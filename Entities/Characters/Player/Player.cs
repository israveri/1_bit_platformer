using Godot;

public partial class Player : BaseCharacter {
	[Export]
	public InputActions Actions { get; set; }

	[Export(PropertyHint.Range, "0,100,1,or_greater")]
	public int MoveSpeed { get; set; } = 50;

	public void GetInput() {
		Direction = Input.GetVector(Actions.Left, Actions.Right, Actions.Up, Actions.Down);

		var velocity = Velocity;
		velocity.X = Direction.X * MoveSpeed;
		Velocity = velocity;
	}

	public override void _PhysicsProcess(double delta) {
		GetInput();
		MoveAndSlide();
	}
}
