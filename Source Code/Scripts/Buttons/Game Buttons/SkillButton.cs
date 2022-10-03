public abstract class SkillButton : GameButton
{
    public abstract string BuildingName { get; }
    public abstract (int, int) Cost { get; protected set; }
    public override void _Ready()
    {
        Disabled = true;
    }
    public bool
    CheckResources()
    {
        if (Resources.Gold > Cost.Item1 && Resources.Tree > Cost.Item2)
        {
            return true;
        }
        else
            return false;
    }
    public override void OnButtonPressed()
    {
        base.OnButtonPressed();
        if (CheckResources())
        {
            GetNode<Board>("/root/Root/Board").ActivateBuildingMode(BuildingName);
        }
        else
        {
            GetNode<AudioStreamPlayer>("/root/Root/Board/Notify").Play();
        }
    }
}