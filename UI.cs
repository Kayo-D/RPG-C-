using System.Collections;
using static System.Console;
using static System.ConsoleKey;

class UI
{
    public ConsoleKeyInfo keyInput;
    public void Menu()
    {
        while (true)
        {
            Clear();
            WriteLine("MENU");
            WriteLine("");
            WriteLine("1: Continue");
            WriteLine("2: New Game");
            WriteLine("3: Exit");
            keyInput = ReadKey();
            switch (keyInput.Key)
            {
                case D1:
                    Level1();
                    break;
                case D2:
                    break;
                case D3:
                    return;
                default:
                    break;
            }
        }
    }
    public void CreateLevel()
    {

    }
    public void Level1()
    {
        TileEngine tiles = new();
        tiles.playerPositionX = 5;
        tiles.playerPositionY = 5;
        tiles.tileCountX = 11;
        tiles.tileCountY = 11;
        for (int i = 0; i < tiles.tileCountY; i++)
        {
            tiles.tileListY.Add(0);
        }
        for (int j = 0; j < tiles.tileCountX; j++)
        {
            tiles.tileListX.Add(0);
        }
        for (int i = 0; i < tiles.tileListY.Count; i++)
        {
            if (i == tiles.playerPositionY)
            {
                for (int j = 0; j < tiles.tileListY.Count; j++)
                {
                    if (j == tiles.playerPositionX && i == tiles.playerPositionY)
                    {
                        tiles.tileListX.RemoveAt(j);
                        tiles.tileListX.Insert(i, 1);
                        tiles.tileListY.RemoveAt(j);
                        tiles.tileListY.Insert(i, 1);
                    }
                }
            }
        }
        while (true)
        {
            Clear();
            for (int i = 0; i < tiles.tileCountY; i++)
            {
                for (int j = 0; j < tiles.tileCountX; j++)
                {
                    if(i == tiles.playerPositionY && j == tiles.playerPositionX)
                    {
                        Write("(X)");
                    }
                    else
                    {
                        Write("( )");
                    }
                }
                WriteLine("");
            }
            WriteLine("");
            WriteLine("Use arrowkeys");
            WriteLine("(Q)uit");
            keyInput = ReadKey();
            Clear();
            switch (keyInput.Key)
            {
                case UpArrow:
                    tiles.tileListX.Clear();
                    tiles.tileListY.Clear();
                    tiles.playerPositionY = tiles.playerPositionY - 1;
                    for (int i = 0; i < tiles.tileCountY; i++)
                    {
                        tiles.tileListY.Add(0);
                    }
                    for (int j = 0; j < tiles.tileCountX; j++)
                    {
                        tiles.tileListX.Add(0);
                    }
                    for (int i = 0; i < tiles.tileListY.Count; i++)
                    {
                        if (i == tiles.playerPositionY)
                        {
                            for (int j = 0; j < tiles.tileListY.Count; j++)
                            {
                                if (j == tiles.playerPositionX && i == tiles.playerPositionY)
                                {
                                    tiles.tileListX.RemoveAt(j);
                                    tiles.tileListX.Insert(i, 1);
                                    tiles.tileListY.RemoveAt(j);
                                    tiles.tileListY.Insert(i, 1);
                                }
                            }
                        }
                    }
                    break;
                case LeftArrow:
                    tiles.tileListX.Clear();
                    tiles.tileListY.Clear();
                    tiles.playerPositionX = tiles.playerPositionX - 1;
                    for (int i = 0; i < tiles.tileCountY; i++)
                    {
                        tiles.tileListY.Add(0);
                    }
                    for (int j = 0; j < tiles.tileCountX; j++)
                    {
                        tiles.tileListX.Add(0);
                    }
                    for (int i = 0; i < tiles.tileListY.Count; i++)
                    {
                        if (i == tiles.playerPositionY)
                        {
                            for (int j = 0; j < tiles.tileListY.Count; j++)
                            {
                                if (j == tiles.playerPositionX && i == tiles.playerPositionY)
                                {
                                    tiles.tileListX.RemoveAt(j);
                                    tiles.tileListX.Insert(i, 1);
                                    tiles.tileListY.RemoveAt(j);
                                    tiles.tileListY.Insert(i, 1);
                                }
                            }
                        }
                    }
                    break;
                case RightArrow:
                    tiles.tileListX.Clear();
                    tiles.tileListY.Clear();
                    tiles.playerPositionX = tiles.playerPositionX + 1;
                    for (int i = 0; i < tiles.tileCountY; i++)
                    {
                        tiles.tileListY.Add(0);
                    }
                    for (int j = 0; j < tiles.tileCountX; j++)
                    {
                        tiles.tileListX.Add(0);
                    }
                    for (int i = 0; i < tiles.tileListY.Count; i++)
                    {
                        if (i == tiles.playerPositionY)
                        {
                            for (int j = 0; j < tiles.tileListY.Count; j++)
                            {
                                if (j == tiles.playerPositionX && i == tiles.playerPositionY)
                                {
                                    tiles.tileListX.RemoveAt(j);
                                    tiles.tileListX.Insert(i, 1);
                                    tiles.tileListY.RemoveAt(j);
                                    tiles.tileListY.Insert(i, 1);
                                }
                            }
                        }
                    }
                    break;
                case DownArrow:
                    tiles.tileListX.Clear();
                    tiles.tileListY.Clear();
                    tiles.playerPositionY = tiles.playerPositionY + 1;
                    for (int i = 0; i < tiles.tileCountY; i++)
                    {
                        tiles.tileListY.Add(0);
                    }
                    for (int j = 0; j < tiles.tileCountX; j++)
                    {
                        tiles.tileListX.Add(0);
                    }
                    for (int i = 0; i < tiles.tileListY.Count; i++)
                    {
                        if (i == tiles.playerPositionY)
                        {
                            for (int j = 0; j < tiles.tileListY.Count; j++)
                            {
                                if (j == tiles.playerPositionX && i == tiles.playerPositionY)
                                {
                                    tiles.tileListX.RemoveAt(j);
                                    tiles.tileListX.Insert(i, 1);
                                    tiles.tileListY.RemoveAt(j);
                                    tiles.tileListY.Insert(i, 1);
                                }
                            }
                        }
                    }
                    break;
                case Q:
                    return;
                default:
                    break;
            }
        }
    }
}