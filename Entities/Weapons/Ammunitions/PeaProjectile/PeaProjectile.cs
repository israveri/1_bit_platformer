using Godot;

public partial class PeaProjectile : RigidBody2D
{
    [Export(PropertyHint.Range, "0,300,1,or_greater")]
    public float InitialVelocity = 300;

    public override void _Ready()
    {
        var linearVelocity = LinearVelocity;
        linearVelocity.X = InitialVelocity;
        LinearVelocity = linearVelocity;
    }
}
