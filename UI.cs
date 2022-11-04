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
            WriteLine("1: Level 1");
            WriteLine("2: Level 2");
            WriteLine("3: Exit");
            keyInput = ReadKey();
            switch (keyInput.Key)
            {
                case D1:
                    Level1();
                    break;
                case D2:
                    Level2();
                    break;
                case D3:
                    return;
                default:
                    break;
            }
        }
    }
    public void Level1()
    {
        TileEngine tiles = new();
        int xBorder = 11;
        int yBorder = 11;
        tiles.playerPositionX = 5;
        tiles.playerPositionY = 5;
        List<int> xBorderList;
        List<int> yBorderlist;
        xBorderList = tiles.CreatePlayBorder(xBorder);
        yBorderlist = tiles.CreatePlayBorder(yBorder);
        while (true)
        {
            UITileEngineUpdate(yBorderlist, xBorderList, tiles.playerPositionY, tiles.playerPositionX);
            WriteLine("");
            WriteLine("Use arrowkeys");
            WriteLine("(Q)uit");
            keyInput = ReadKey();
            if (keyInput.Key == Q)
            {
                return;
            }
            else
            {
                tiles.PlayerPositionUpdate(keyInput);
                xBorderList = tiles.CreatePlayBorder(xBorder);
                yBorderlist = tiles.CreatePlayBorder(yBorder);
            }
        }
    }
    public void Level2()
    {
        TileEngine tiles = new();
        int xBorder = 22;
        int yBorder = 22;
        tiles.playerPositionX = 10;
        tiles.playerPositionY = 10;
        List<int> xBorderList;
        List<int> yBorderlist;
        xBorderList = tiles.CreatePlayBorder(xBorder);
        yBorderlist = tiles.CreatePlayBorder(yBorder);
        while (true)
        {
            UITileEngineUpdate(yBorderlist, xBorderList, tiles.playerPositionY, tiles.playerPositionX);
            WriteLine("");
            WriteLine("Use arrowkeys");
            WriteLine("(Q)uit");
            keyInput = ReadKey();
            if (keyInput.Key == Q)
            {
                return;
            }
            else
            {
                tiles.PlayerPositionUpdate(keyInput);
                xBorderList = tiles.CreatePlayBorder(xBorder);
                yBorderlist = tiles.CreatePlayBorder(yBorder);
            }
        }
    }
    public void UITileEngineUpdate(List<int> yBorderList, List<int> xBorderList, int playerPositionY, int playerPositionX)
    {
        Clear();
        for (int i = 0; i < yBorderList.Count; i++)
        {
            for (int j = 0; j < xBorderList.Count; j++)
            {
                if (i == playerPositionY && j == playerPositionX)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Write(" ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            WriteLine("");
        }
        yBorderList.Clear();
        xBorderList.Clear();
    }
    /* public void Level1()
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
                    if (i == tiles.playerPositionY && j == tiles.playerPositionX)
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
    } */
}