public class Board : Spatial
{
    /// <summary>
    /// Список имён всех тайлов местности
    /// </summary>
    private string[] weights = File.ReadAllLines(@"Assets\Weights.ini");
    private Dictionary<string, (int, int)> tileWeights = new Dictionary<string, (int, int)>();
    /// <summary>
    /// Массив тайлов карты
    /// </summary>
    public List<MeshInstance> Tiles { get; private set; } = new List<MeshInstance>();
    public List<Building> Buildings { get; private set; } = new List<Building>();

    public static Building NewBuilding { get; set; }
    public static bool BuildingModeActive { get; set; }
    public override void _Ready()
    {
        Resources.Gold = 1000;
        Resources.Tree = 500;
        Control Minimap = GetNode<Control>("/root/Root/HUD/Minimap/MapTiles");
        for (int i = 1; i < weights.Length; i++)
        {
            string tile = weights[i];
            string tileKey = tile.Remove(tile.IndexOf(" "));
            tile = tile.Remove(0, tile.IndexOf(" ") + 1);
            int tileValue1 = Convert.ToInt32(tile.Remove(tile.IndexOf(" ")));
            tile = tile.Remove(0, tile.IndexOf(" ") + 1);
            int tileValue2 = Convert.ToInt32(tile);
            tileWeights.Add(tileKey, (tileValue1, tileValue2));
        }
        // Генерим карту
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 50; j++)
            {
                string tileName = BlessRNG(tileWeights);
                ColorRect minimapTile = GD.Load<PackedScene>($"res://Assets/Scenes/Game/MinimapTile.tscn").Instance<ColorRect>();
                minimapTile.Material = GD.Load<Material>($"res://Assets/Textures/Interface/Minimap/{tileName}.tres");
                minimapTile.MarginTop = j * 4;
                minimapTile.MarginBottom = j * 4 + 4;
                minimapTile.MarginLeft = i * 4;
                minimapTile.MarginRight = i * 4 + 4;
                Minimap.AddChild(minimapTile);
                MeshInstance tile = GD.Load<PackedScene>($"res://Assets/Templates/Terrain/{tileName}.tscn").Instance<MeshInstance>();
                tile.Translation = new Vector3(i * 2.5F - 127.5F, 0, j * 2.5F - 62.5F);
                GetNode("Tiles").AddChild(tile);
                Tiles.Add(tile);
            }
        Minimap.AddChild(GD.Load<PackedScene>($"res://Assets/Scenes/Game/MapPosition.tscn").Instance<ColorRect>());
    }
    /// <summary>
    /// Выдаём название тайла рандомно, с учётом его веса
    /// </summary>
    /// <param name = "dict"> Список всех тайлов </param>
    private string BlessRNG(Dictionary<string, (int, int)> dict)
    {
        Random rng = new Random();
        int maxIndex = Convert.ToInt32(weights[0]);
        int result = rng.Next(1, maxIndex);
        foreach (KeyValuePair<string, (int, int)> weight in dict)
        {
            if (result >= weight.Value.Item1 && result <= weight.Value.Item2)
                return weight.Key;
        }
        throw new Exception("Ошибка генерации тайла");
    }

    public void ActivateBuildingMode(string name)
    {
        BuildingModeActive = true;
        NewBuilding = GD.Load<PackedScene>($"res://Assets/Templates/Buildings/{name}.tscn").Instance<Building>();
        GetNode("Tiles").AddChild(NewBuilding);
    }
    public void DeactivateBuildingMode()
    {
        BuildingModeActive = false;
        NewBuilding = null;
    }
}