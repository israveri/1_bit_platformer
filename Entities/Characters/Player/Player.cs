using Godot;

public partial class Player : BaseCharacter
{
    public override void _PhysicsProcess(double delta)
    {
        _applyGravity(delta);
        _handleHorizontalMovement();
        MoveAndSlide();
    }

    private void _handleHorizontalMovement()
    {
        var velocity = Velocity;
        velocity.X = Direction.X * MoveSpeed;
        Velocity = velocity;
    }
}
