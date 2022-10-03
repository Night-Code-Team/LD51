public class MineButton : SkillButton
{
    public override string BuildingName { get; } = "mine";
    public override (int, int) Cost { get; protected set; } = (100, 50);
}
