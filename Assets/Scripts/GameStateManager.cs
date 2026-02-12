using System.Runtime.CompilerServices;
using UnityEngine;



public enum GameState
{
    None,
        Init,
        MainMenu,
        Gameplay,
        Paused


}

public class GameStateManager : MonoBehaviour
{
    //[SerializeField] 
    private ServiceHub serviceHub;
    private UIManager uiManager;
    public GameState currentState { get; private set; }
    public GameState previousState { get; private set; }

    [Header("Debug (read Only)")]
    [SerializeField] private string currentActiveState;
    [SerializeField] private string previousActiveState;

    private void Start()
    {

        serviceHub = ServiceHub.Instance;
        uiManager = serviceHub.UIManager;

        SetState(GameState.Init);


    }



    public void SetState(GameState newState)
    {
        if (currentState == newState) return;

        previousState = currentState;
        currentState = newState;

        currentActiveState = currentState.ToString();

        previousActiveState = previousState.ToString();

        OnGameStateChanged(previousState, currentState);
    }





    private void OnGameStateChanged(GameState previousState, GameState currentState)
    {

        switch (currentState)
        {


            case GameState.None:

                Debug.Log("this should never show up");
                break;

            case GameState.Init:
                Time.timeScale = 0;
                SetState(GameState.MainMenu);
                Debug.Log("this game is initalized");
                break;

            case GameState.MainMenu:
                Time.timeScale = 1;
                uiManager.ShowMainMenuUI();
                Debug.Log("this game is main menup");
                break;

            case GameState.Gameplay:
                Time.timeScale = 1;
                uiManager.ShowGameplayUI();
                Debug.Log("this game is glameplayp");
                break;

            case GameState.Paused:

                Time.timeScale = 0;

             
                uiManager.ShowPausedUI();

                Debug.Log("this game is paused");


                break;
                       
            default:
                break;
        }

    }

    //private void Update()
    //{
    //    // For testing purposes, we can use keyboard input to change states
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (currentState == GameState.MainMenu)
    //        {
    //            SetState(GameState.Gameplay);
    //            return;
    //        }
    //        else if (currentState == GameState.Gameplay)
    //        {
    //            SetState(GameState.Paused);
    //            return;
    //        }
    //        else if (currentState == GameState.Paused)
    //        {
    //            SetState(GameState.Init);
    //            return;
    //        }
    //    }
    //}




    //public void OnStartGameButtonPressed()


    public void StartGame()

    {
        SetState(GameState.Gameplay);

    }
    //public void OnPauseButtonPressed()
            public void TogglePause()
    {
        if (currentState == GameState.Paused)
        {

            if (currentState == GameState.Gameplay) return;

                SetState(GameState.Gameplay);

        }
        else if (currentState == GameState.Gameplay)
        {

            if (currentState == GameState.Paused) return;
            SetState(GameState.Paused);

        }
    }
}
        