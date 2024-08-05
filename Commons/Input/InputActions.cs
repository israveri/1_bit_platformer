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

  [Export]
  public StringName Jump  { get; set; } = "jump";

  [Export]
  public StringName Shoot { get; set; } = "shoot";
}
