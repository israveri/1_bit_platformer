using Godot;

public partial class Shooter : Node2D
{
    [Export]
    public bool CanShoot = true;

    [Export]
    public Ammunition Ammunition;

    [Export]
    public GroupNames GroupNames;

    public Node AmmunitionNode;

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
    }
}
