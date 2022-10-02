public class EnemyMarker : ColorRect
{
    public int Position { get; set; }
    public KinematicBody Enemy { get; set; }
    public override void _Process(float delta)
    {
        MarginTop = Enemy.Translation.z * 1.6F + 98;
        MarginBottom = Enemy.Translation.z * 1.6F + 102;
        MarginLeft = Enemy.Translation.x * 1.6F + 198;
        MarginRight = Enemy.Translation.x * 1.6F + 202;
    }
}