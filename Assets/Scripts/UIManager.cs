using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject PausedUI;

    public GameObject GameplayUI;

    public GameObject GameOverUI;

    private void HideAllUI()
    {
        MainMenuUI.SetActive(false);
        PausedUI.SetActive(false);
        GameplayUI.SetActive(false);
        GameOverUI.SetActive(false);
    }

    public void ShowMainMenuUI()
    {
        HideAllUI();
        MainMenuUI.SetActive(true);
    }

    public void ShowGameplayUI()
    {
        HideAllUI();
        GameplayUI.SetActive(true);
    }

    public void ShowGameOverUI()
    {
        HideAllUI();
        GameOverUI.SetActive(true);
    }

    public void ShowPausedUI()
    {
        PausedUI.SetActive(true);
    }
}
