using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public enum GameState
    {
        MainMenu,
        Math,
        Eng,
        Paused
    }


    private GameState currentState = GameState.MainMenu;

    public delegate void OnStateChanged(GameState newState);
    public event OnStateChanged onStateChanged;
    public GameState CurrentState 
    { 
        get { return currentState; }
    }
    
    protected override void Awake()
    {
        base.Awake();
    }

    public void ChangeState(GameState newState)
    {
        if (currentState == newState)
        {
            return;
        }
        
        currentState = newState;
        
        onStateChanged?.Invoke(newState);
        
        switch (newState)
        {
            case GameState.MainMenu:
                Debug.Log("Главное меню");
                break;
                
            case GameState.Math:
                Debug.Log("Математика");
                break;

            case GameState.Eng:
                Debug.Log("Англ");
                break;
                
            case GameState.Paused:
                Debug.Log("Игра на паузе");
                break;
        }
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("Math");
    }

    // public void RestartLevel()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //     ChangeState(GameState.Playing);
    // }

}
