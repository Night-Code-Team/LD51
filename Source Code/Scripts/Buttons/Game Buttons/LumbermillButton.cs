public class LumbermillButton : SkillButton
{
    public override (int, int) Cost { get; protected set; } = (100, 50);
    public override void OnButtonPressed()
    {
        base.OnButtonPressed();
        if (CheckResources())
        {
            GetNode<Board>("/root/Root/Board").ActivateBuildingMode("lumber");
        }
        else
        {

        }
    }
}
