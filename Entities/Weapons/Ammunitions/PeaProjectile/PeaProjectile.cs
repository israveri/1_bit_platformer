using Godot;

public partial class PeaProjectile : RigidBody2D
{
    [Export(PropertyHint.Range, "0,300,1,or_greater")]
    public float InitialVelocity = 300;

    public void Shoot(Vector2 direction)
    {
        LinearVelocity = InitialVelocity * direction;
    }
}
