public class WallButton : SkillButton
{
    public override (int, int) Cost { get; protected set; } = (30, 10);
    public override void OnButtonPressed()
    {
        base.OnButtonPressed();
        if (CheckResources())
        {
            Building.ActivateBuildingMode("wall");
        }
        else
        {

        }
    }
}