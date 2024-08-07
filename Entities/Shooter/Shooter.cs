using Godot;

public partial class Shooter : Node2D
{
    [Export]
    public bool CanShoot = true;

    [Export]
    public Ammunition Ammunition;

    public GroupNames GroupNames = new GroupNames();
    public Node AmmunitionNode;
    public Vector2 DefaultShootingDirection = Vector2.Right;

    public override void _Ready()
    {
        AmmunitionNode = GetTree().GetFirstNodeInGroup(GroupNames.AmmunitionsGroup);
    }

    public bool Shoot()
    {
        if (CanShoot)
        {
            _executeShoot();
            return true;
        }

        return false;
    }

    private void _executeShoot()
    {
        var bullet = Ammunition.Scene.Instantiate() as PeaProjectile;
        AmmunitionNode.AddChild(bullet);

        bullet.Name = Ammunition.DisplayName;
        bullet.GlobalPosition = GlobalPosition;
        bullet.Shoot(direction: DefaultShootingDirection.Rotated(GlobalRotation));
    }
}
