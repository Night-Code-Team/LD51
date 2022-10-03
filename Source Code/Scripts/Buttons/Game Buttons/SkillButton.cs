public abstract class SkillButton : GameButton
{
    public abstract (int, int) Cost { get; protected set; }
    public bool CheckResources()
    {
        if (Resources.Gold > Cost.Item1 && Resources.Tree > Cost.Item2)
        {
            return true;
        }
        else
            return false;
    }
}