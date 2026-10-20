using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void StartButton()
    {
        ServiceHubManager.Instance.gameStateManager.SwitchGameStates(Gamestate.gameplay);
    }

    public void MainMenuButton()
    {
        ServiceHubManager.Instance.gameStateManager.SwitchGameStates(Gamestate.mainMenu);
    }

    public void GameOverButton()
    {
        ServiceHubManager.Instance.gameStateManager.SwitchGameStates(Gamestate.gameOver);
    }

    public void ResumeButton()
    {
        ServiceHubManager.Instance.gameStateManager.SwitchGameStates(ServiceHubManager.Instance.gameStateManager.previousState);

        if (ServiceHubManager.Instance.gameStateManager.currentState == Gamestate.paused)
        {
            ServiceHubManager.Instance.gameStateManager.previousState = Gamestate.gameplay;
        }
    }

    public void PauseToggle()
    {
        if(ServiceHubManager.Instance.gameStateManager.currentState == Gamestate.gameplay)
        {
            if (ServiceHubManager.Instance.gameStateManager.currentState == Gamestate.paused) return;
            ServiceHubManager.Instance.gameStateManager.SwitchGameStates(Gamestate.paused);
        }
        else if (ServiceHubManager.Instance.gameStateManager.currentState == Gamestate.paused)
        {
            if (ServiceHubManager.Instance.gameStateManager.currentState == Gamestate.gameplay) return;
            ServiceHubManager.Instance.gameStateManager.SwitchGameStates(Gamestate.gameplay);
        }
    }
}
