using Godot;

public partial class PlayerInput : Node
{
    [Export]
    public Player Player;

    [Export]
    public Shooter Shooter;

    [Export]
    public InputActions InputActions { get; set; }

    public override void _Process(double delta)
    {
        Player.Direction = Input.GetVector(
            InputActions.Left,
            InputActions.Right,
            InputActions.Up,
            InputActions.Down
        );
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event.IsActionPressed(InputActions.Jump))
            Player.Jump();

        if (@event.IsActionPressed(InputActions.Shoot))
            Shooter.Shoot();
    }
}
