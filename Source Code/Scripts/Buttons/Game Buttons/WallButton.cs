public class WallButton : SkillButton
{
    public override string BuildingName { get; } = "wall";
    public override (int, int) Cost { get; protected set; } = (30, 10);
}