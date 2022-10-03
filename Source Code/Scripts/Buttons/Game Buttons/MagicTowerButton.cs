public class MagicTowerButton : SkillButton
{
    public override (int, int) Cost { get; protected set; } = (500, 300);
    public override void OnButtonPressed()
    {
        base.OnButtonPressed();
        if (CheckResources())
        {
            GetNode<Board>("/root/Root/Board").ActivateBuildingMode("magic-tower");
        }
        else
        {

        }
    }
}