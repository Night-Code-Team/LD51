public class Quit : MenuButton
{
    protected override void _OnButtonPressed()
    {
        GetTree().Quit();
    }
}