public class TreeTick : Timer
{
    private void OnTimerTimeout()
    {
        Resources.Tree += 10;
    }
}