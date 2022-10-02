using System.IO;
public class Spawn : Timer
{
    private void OnSpawnTimeout()
    {
        Random rng = new Random();
        float rngx = 0;
        float rngy = 0;
        for (int i = 0; i <= 5; i++)
        {
            string[] enemies = System.IO.Directory.GetFiles(@"Assets\Templates\NPC");
            KinematicBody Enemy = GD.Load<PackedScene>($"res://{enemies[rng.Next(0, 2)]}").Instance<KinematicBody>();
            Enemy.Translation = new Vector3((float)rng.NextDouble() * 250 - 114, 5, (float)rng.NextDouble() * 125 - 57F);
            EnemyMarker marker = GD.Load<PackedScene>("res://Assets/Scenes/Game/EnemyMarker.tscn").Instance<EnemyMarker>();
            marker.Enemy = Enemy;
            GetNode("/root/Root/HUD/Minimap/Enemies").AddChild(marker);
            GetNode("/root/Root/Board").AddChild(Enemy);
        }
    }
}