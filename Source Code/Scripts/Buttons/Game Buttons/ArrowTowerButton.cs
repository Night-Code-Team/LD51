public class ArrowTowerButton : SkillButton
{
    public override (int, int) Cost { get; protected set; } = (100, 40);
    public override void OnButtonPressed()
    {
        base.OnButtonPressed();
        if (CheckResources())
        {
            GetNode<Board>("/root/Root/Board").ActivateBuildingMode("arrow-tower");
        }
        else
        {
        }
    }
}