using Godot;
using System;

public class Tiles : Spatial
{
    public Tiles TilesHolder { get; private set; }
    public override void _Ready()
    {
        TilesHolder = this;
    }
}
