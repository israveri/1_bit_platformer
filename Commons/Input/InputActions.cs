using Godot;

[GlobalClass]
public partial class InputActions : Resource {
  [Export]
  public StringName Up    { get; set; } = "up";

  [Export]
  public StringName Down  { get; set; } = "down";

  [Export]
  public StringName Left  { get; set; } = "left";

  [Export]
  public StringName Right { get; set; } = "right";
}
