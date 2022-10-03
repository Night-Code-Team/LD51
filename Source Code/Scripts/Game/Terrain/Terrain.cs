public abstract class Terrain : MeshInstance
{
    public abstract string TileName { get; }
    private Building building;
    public virtual void OnMouseEntered()
    {
        building = Board.NewBuilding;
        if (Board.BuildingModeActive && building != null)
        {
            building.Translation = Translation;
            switch (TileName)
            {
                case "grass":
                    {
                        if (building.BuildingName != "mine" && building.BuildingName != "lumber")
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
                        if (building.BuildingName != "lumber")
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
                        if (building.BuildingName != "mine")
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
            }
        }
    }
    public override void _Process(float delta)
    {
        if (Board.BuildingModeActive && building != null)
        {
            if (Input.IsActionJustPressed("LeftClick"))
            {
                if (building.Available)
                {
                    List<MeshInstance> list = GetNode<Board>("/root/Root/Board").Tiles;
                    building.SetSurfaceMaterial(0, building.Default);
                    list[list.IndexOf(this)] = building;
                    Board.BuildingModeActive = false;
                    GetNode("/root/Root/Board/Tiles").RemoveChild(building);
                }
                else
                {
                    Board.BuildingModeActive = false;
                    GetNode("/root/Root/Board/Tiles").RemoveChild(building);
                }
            }
        }
    }
}