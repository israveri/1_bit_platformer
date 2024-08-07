using Godot;

public partial class DirectionFacingControl : Node2D
{
    [Export]
    public BaseCharacter Character
    {
        get { return _character; }
        set
        {
            if (IsInstanceValid(_character))
                _character.DirectionChanged -= DirectionChangedEventHandler;

            _character = value;

            if (IsInstanceValid(_character))
                _character.DirectionChanged += DirectionChangedEventHandler;
        }
    }
    private BaseCharacter _character;

    public void DirectionChangedEventHandler(Vector2 direction)
    {
        if (direction.X == 0)
            return;

        var scale = Scale;
        scale.X = Mathf.Abs(Scale.X) * Mathf.Sign(direction.X);
        Scale = scale;
    }
}
