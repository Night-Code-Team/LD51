public class ArrowTowerButton : SkillButton
{
    public override string BuildingName { get; } = "arrow-tower";
    public override (int, int) Cost { get; protected set; } = (100, 40);
}