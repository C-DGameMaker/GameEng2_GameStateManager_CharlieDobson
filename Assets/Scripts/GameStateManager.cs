using UnityEngine;

public enum Gamestate
{
    mainMenu,
    gameplay,
    paused,
    gameOver


}
public class GameStateManager : MonoBehaviour
{
    public Gamestate currentState;
    public Gamestate previousState;

    private void Start()
    {
        SwitchGameStates(Gamestate.mainMenu);
    }
    public void SwitchGameStates(Gamestate newState)
    {
        previousState = currentState;
        currentState = newState;

        OnGameStateSwitch(newState);
    }

    private void OnGameStateSwitch(Gamestate newState)
    {
        switch (newState)
        {
            default:
                break;

            case Gamestate.mainMenu:
                    break;

            case Gamestate.gameplay:
                Time.timeScale = 1;
                break;

            case Gamestate.paused:
                Time.timeScale = 0;
                break;

            case Gamestate.gameOver:
                break;
        }

    }
}
