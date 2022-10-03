public class MagicTowerButton : SkillButton
{
    public override string BuildingName { get; } = "magic-tower";
    public override (int, int) Cost { get; protected set; } = (500, 300);
}