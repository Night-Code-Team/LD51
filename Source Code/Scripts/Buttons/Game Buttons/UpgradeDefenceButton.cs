public class UpgradeDefenceButton : SkillButton
{
    public override string BuildingName { get; } = "DefenceGrade";
    public override (int, int) Cost { get; protected set; } = (100, 100);
}