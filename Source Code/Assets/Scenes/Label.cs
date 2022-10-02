public class Label : Godot.Label
{
    public override void _Process(float delta)
    {
        Text = GetViewport().GetMousePosition().ToString();
    }
}