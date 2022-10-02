public class Board : Spatial
{
    private string[] tileNames = System.IO.Directory.GetFiles(@"Assets\Templates");
    public int[,] Tiles { get; private set; } = new int[100, 50];
    public override void _Ready()
    {
        Random blessRNG = new Random();
        int rng = tileNames.Length - 1;
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 50; j++)
            {
                MeshInstance tile = GD.Load<PackedScene>($"res://{tileNames[blessRNG.Next(0, rng)]}").Instance<MeshInstance>();
                tile.Translation = new Vector3(i * 2.5F - 127.5F, 0, j * 2.5F - 62.5F);
                AddChild(tile);
            }
    }

}