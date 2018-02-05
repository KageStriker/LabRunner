using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum GameState
{
    MainMenu,
    LevelSelect,
    Loading,
    Playing,
    Paused,
    ExitGame
}

public class GameManager : MonoBehaviour
{
    static GameManager _instance = null;
    private int unlockedLevel;
    private GameState gameState;
    
    void Start ()
    {
        if (instance)
            DestroyImmediate(gameObject);
        else
        {
            instance = this;

            DontDestroyOnLoad(this);
        }

        gameState = GameState.MainMenu;
    }
	
	void Update ()
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                break;
            case GameState.LevelSelect:
                break;
            case GameState.Loading:
                break;
            case GameState.Playing:
                break;
            case GameState.Paused:
                break;
            case GameState.ExitGame:
                break;
        }
    }

    public void TempLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void LoadSceneAtIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    private void LoadLevel(int index)
    {
        if (index < 10)
            SceneManager.LoadScene("Level_0" + index);
        else
            SceneManager.LoadScene("Level_" + index);
    }

    public static GameManager instance
    {
        get { return _instance; }
        set { _instance = value; }
    }
}
