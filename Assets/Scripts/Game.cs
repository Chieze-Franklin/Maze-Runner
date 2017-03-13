using UnityEngine;
using System.Collections;

public class Game {
    public static float Duration { get; set; }
    public static GameStates GameState { get; set; }
    public static int MazeColumns { get; set; }
    public static int MazeRows { get; set; }
    public static float MazeScale { get; set; }

    public static void SetLevelStats(int level) 
    {
        switch (level) 
        {
            case 1:
                Duration = 30;
                GameState = GameStates.InPlay;
                MazeScale = 2;
                MazeRows = 10;
                MazeColumns = 10;
                break;
            case 2:
                Duration = 60;
                GameState = GameStates.InPlay;
                MazeScale = 3.4f;
                MazeRows = 11;
                MazeColumns = 11;
                break;
            default:
                GameState = GameStates.GoodBye;
                break;
        }
    }
}

public enum GameStates { Welcome = 0, InPlay, Pause, Win, Loss, GoodBye }
