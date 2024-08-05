using Godot;

public partial class Player : BaseCharacter {
	[Export(PropertyHint.Range, "0,100,1,or_greater")]
	public int MoveSpeed { get; set; } = 50;

	public void HandleVelocity() {
		var velocity = Velocity;
		velocity.X = Direction.X * MoveSpeed;
		Velocity = velocity;
	}

	public override void _PhysicsProcess(double delta) {
		HandleVelocity();
		MoveAndSlide();
	}
}
