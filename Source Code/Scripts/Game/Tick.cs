public class Tick : Timer
{
    public static int GoldTick { get; set; }
    public static int TreeTick { get; set; }
    public void OnTick()
    {
        Resources.Gold += GoldTick;
        Resources.Tree += TreeTick;
    }
}