public class GoldTick : Timer
{
    private void OnTimerTimeout()
    {
        Resources.Gold += 10;
    }
}