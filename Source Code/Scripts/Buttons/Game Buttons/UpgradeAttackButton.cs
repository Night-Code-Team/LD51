public class UpgradeAttackButton : SkillButton
{
    public override string BuildingName { get; } = "AttackGrade";
    public override (int, int) Cost { get; protected set; } = (100, 100);
}
