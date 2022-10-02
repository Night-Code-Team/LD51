public class Start : MenuButton
{
    protected override void _OnButtonPressed()
    {
        GetTree().ChangeScene("res://Assets/Scenes/Game/Game.tscn");
    }
}