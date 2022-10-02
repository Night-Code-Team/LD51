public class OpeningTimer : Timer
{
    private bool change = false;
    private void OnTimerTimeout()
    {
        if (!change)
        {
            GetParent<UI>().Close();
            this.WaitTime = 1;
            this.Start();
            change = true;
        }
        else
        {
#if DEBUG
            GetTree().ChangeScene("res://Assets/Scenes/Game/Game.tscn");
#else
            GetTree().ChangeScene("res://Assets/Scenes/Main Menu/Main Menu.tscn");
#endif
        }
    }
}