public abstract class Building : Tile
{
    public abstract float HP { get; set; }
    public abstract float MaxHP { get; set; }
    public abstract float Regen { get; set; }
    public abstract (int, int) Cost { get; protected set; }
    public Material Red { get; set; }
    public Material Green { get; set; }
    public Material Default { get; set; }
    public bool Available { get; set; }
    public override void _Ready()
    {
        HP = MaxHP;
        Red = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-red.tres");
        Green = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-green.tres");
        Default = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-default.tres");
    }
    public override void _Process(float delta)
    {
        if (HP < MaxHP)
            HP += Regen;
        if (HP <= 0)
        {
            Ruin();
        }
    }
    public virtual void Ruin()
    {
        Board board = GetNode<Board>("/root/Root/Board");
        Tile[,] tiles = board.Tiles;
        switch (TileName)
        {
            case "mine":
                {
                    tiles[X, Y] = GD.Load<PackedScene>($"res://Assets/Templates/Terrain/gold.tscn").Instance<Tile>();
                    break;
                }
            case "lumber":
                {
                    tiles[X, Y] = GD.Load<PackedScene>($"res://Assets/Templates/Terrain/forest.tscn").Instance<Tile>();
                    break;
                }
            default:
                {
                    tiles[X, Y] = GD.Load<PackedScene>($"res://Assets/Templates/Terrain/grass.tscn").Instance<Tile>();
                    break;
                }
        }
        tiles[X, Y].Translation = Translation;
        board.GetNode("Tiles").AddChild(tiles[X, Y]);
        GetNode<Board>("/root/Root/Board").Buildings.Remove(this);
        GetNode("/root/Root/Board/Tiles").RemoveChild(this);
    }
}