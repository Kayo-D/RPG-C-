using static System.ConsoleKey;
public class TileEngine
{
    public List<int> tileListX = new List<int>();
    public List<int> tileListY = new List<int>();
    public int tileCountX;
    public int tileCountY;
    public int playerPositionX;
    public int playerPositionY;
    public List<int> CreatePlayBorder(int playBorder)
    {
        List<int> playborderList = new();
        for (int i = 0; i < playBorder; i++)
        {
            playborderList.Add(0);
        }
        return playborderList;
    }
    public void PlayerPositionUpdate(ConsoleKeyInfo keyInput)
    {
        List<int> playerPositionListX = new();
        switch (keyInput.Key)
        {
            case UpArrow:
                playerPositionY = playerPositionY - 1;
                break;
            case LeftArrow:
                playerPositionX = playerPositionX - 1;
                break;
            case RightArrow:
                playerPositionX = playerPositionX + 1;
                break;
            case DownArrow:
                playerPositionY = playerPositionY + 1;
                break;
            default:
                break;
        }
    }
}