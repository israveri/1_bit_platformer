using Godot;

public partial class Ammunition : Resource
{
    [Export]
    public StringName DisplayName;

    [Export]
    public Texture2D Icon;

    [Export]
    public PackedScene Scene;
}
