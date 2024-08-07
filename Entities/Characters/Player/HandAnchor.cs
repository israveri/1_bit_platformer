using Godot;

public partial class HandAnchor : Node2D
{
    public override void _Process(double delta)
    {
        Vector2 CursorPosition = GetGlobalMousePosition();
        Rotation = GlobalPosition.AngleToPoint(CursorPosition);
    }
}
