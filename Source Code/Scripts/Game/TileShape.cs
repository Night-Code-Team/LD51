public class TileShape : KinematicBody
{
    public void OnMouseEntered()
    {
        Translation = new Vector3(Translation.x, Translation.y + 2, Translation.z);
    }
}