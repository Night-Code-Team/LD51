public class MainBaseButton : SkillButton
{
    public override string BuildingName { get; } = "main";
    public override void _Ready()
    {
    }
    public override (int, int) Cost { get; protected set; } = (500, 300);
}