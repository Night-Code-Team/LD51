public class TreeValue : Label
{
    public override void _Ready()
    {
        Text = "500";
    }
    public override void _Process(float delta)
    {
        Text = Resources.Tree.ToString();
    }
}