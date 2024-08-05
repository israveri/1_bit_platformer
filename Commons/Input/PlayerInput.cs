using Godot;

public partial class PlayerInput : Node {
	[Export]
	public BaseCharacter Character;

	[Export]
	public InputActions InputActions { get; set; }

	public override void _PhysicsProcess(double delta) {
		Character.Direction = Input.GetVector(
			InputActions.Left,
			InputActions.Right,
			InputActions.Up,
			InputActions.Down
		);
	}
}
