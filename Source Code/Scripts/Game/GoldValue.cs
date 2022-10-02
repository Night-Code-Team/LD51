public class GoldValue : Label
{
    public override void _Ready()
    {
        Text = "1000";
    }
    public override void _Process(float delta)
    {
        Text = Resources.Gold.ToString();
    }
}