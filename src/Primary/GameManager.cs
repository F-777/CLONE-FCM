using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState CurrentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        switch (CurrentState)
        {
            case GameState.MainMenu:
                // Handle Main Menu state
                break;
            case GameState.Playing:
                // Handle Playing state
                break;
            case GameState.Paused:
                // Handle Paused state
                break;
        }
    }
}

public enum GameState
{
    MainMenu,
    Playing,
    Paused
}