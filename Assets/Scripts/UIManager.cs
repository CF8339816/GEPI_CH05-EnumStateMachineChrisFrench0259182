using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject pausedUI;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject settingsUI;
    //private void Start()
    //{
    //    HideAllMenus();
    //    ShowMainMenuUI();
    //}
    public void ShowMainMenuUI()
    {
        Debug.Log("UI manager Show MainMenu UI Called");

        HideAllMenus();
        mainMenuUI.SetActive(true);

    }

    public void ShowGameplayUI()
    {
        Debug.Log("UI manager Show Gameplay UI Called");

        HideAllMenus();

        gameplayUI.SetActive(true);
    }


    public void ShowPausedUI()
    {
        Debug.Log("UI manager Show Paused UI Called");

        HideAllMenus();
        gameplayUI.SetActive(true);
        pausedUI.SetActive(true);       
    }

    public void ShowSettingsUI()
    {
        Debug.Log("UI manager Show Settings UI Called");

        HideAllMenus();
        gameplayUI.SetActive(true);
        settingsUI.SetActive(true);
    }
    public void ShowGameOverUI()
    {
        Debug.Log("UI manager Show Game Over UI Called");

        HideAllMenus();
        gameplayUI.SetActive(true);
        gameOverUI.SetActive(true);
    }







    public void HideAllMenus()
    {
        mainMenuUI.SetActive(false);
        gameplayUI.SetActive(false);
        pausedUI.SetActive(false);

    }

}
