public class LumbermillButton : SkillButton
{
    public override string BuildingName { get; } = "lumber";
    public override (int, int) Cost { get; protected set; } = (100, 50);
}
