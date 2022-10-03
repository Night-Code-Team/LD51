public abstract class Tile : MeshInstance
{
    public int X { get; set; }
    public int Y { get; set; }
    public abstract string TileName { get; set; }
    public bool Active { get; set; } = false;
    private Building building;
    public virtual void OnMouseEntered()
    {
        Active = true;
        building = Board.NewBuilding;
        if (Board.BuildingModeActive && building != null)
        {
            building.Translation = Translation;
            switch (TileName)
            {
                case "grass":
                    {
                        if (building.TileName != "mine" && building.TileName != "lumber")
                        {
                            building.SetSurfaceMaterial(0, building.Green);
                            building.Available = true;
                        }
                        else
                        {
                            building.SetSurfaceMaterial(0, building.Red);
                            building.Available = false;
                        }
                        return;
                    }
                case "rock":
                    {
                        building.SetSurfaceMaterial(0, building.Red);
                        building.Available = false;
                        return;
                    }
                case "forest":
                    {
                        if (building.TileName != "lumber")
                        {
                            building.SetSurfaceMaterial(0, building.Red);
                            building.Available = false;
                        }
                        else
                        {
                            building.SetSurfaceMaterial(0, building.Green);
                            building.Available = true;
                        }
                        return;
                    }
                case "gold":
                    {
                        if (building.TileName != "mine")
                        {
                            building.SetSurfaceMaterial(0, building.Red);
                            building.Available = false;
                        }
                        else
                        {
                            building.SetSurfaceMaterial(0, building.Green);
                            building.Available = true;
                        }
                        return;
                    }
                default:
                    {
                        building.SetSurfaceMaterial(0, building.Red);
                        building.Available = false;
                        return;
                    }
            }
        }
    }
    private void OnMouseExited()
    {
        Active = false;
    }
    public override void _Process(float delta)
    {
        if (Board.BuildingModeActive && building != null && Active)
        {
            if (Input.IsActionJustPressed("LeftClick"))
            {
                Board board = GetNode<Board>("/root/Root/Board");
                Tile[,] tiles = board.Tiles;
                if (building.Available)
                {
                    if (building.Name == "main")
                    {
                        board.MainEstablished();
                        Board.Main = Translation;
                    }
                    else if (building.Name == "mine")
                    {
                        Tick.GoldTick += 10;
                    }
                    else if (building.Name == "lumber")
                    {
                        Tick.TreeTick += 15;
                    }
                    tiles[X, Y] = GD.Load<PackedScene>($"res://Assets/Templates/Buildings/{building.TileName}.tscn").Instance<Tile>();
                    tiles[X, Y].Translation = Translation;
                    Resources.Gold -= ((Building)tiles[X, Y]).Cost.Item1;
                    Resources.Tree -= ((Building)tiles[X, Y]).Cost.Item2;
                    board.GetNode("Tiles").AddChild(tiles[X, Y]);
                    GetNode("/root/Root/Board/Tiles").RemoveChild(building);
                    board.Buildings.Add((Building)tiles[X, Y]);
                    Board.BuildingModeActive = false;
                    GetNode("/root/Root/Board/Tiles").RemoveChild(this);
                }
                else
                {
                    Board.BuildingModeActive = false;
                    GetNode("/root/Root/Board/Tiles").RemoveChild(building);
                }
            }
            if (Input.IsActionJustPressed("RightClick"))
            {
                Board.BuildingModeActive = false;
                GetNode("/root/Root/Board/Tiles").RemoveChild(building);
            }
        }
    }
}