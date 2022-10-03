using Godot;
using System;

public class Menu : MenuButton
{
    protected override void _OnButtonPressed()
    {
        GetTree().ChangeScene("res://Assets/Scenes/Main Menu/Main Menu.tscn");
    }
}
