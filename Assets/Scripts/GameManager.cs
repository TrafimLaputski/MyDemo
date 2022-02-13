using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public System.Action GoToMenuAction;
    public System.Action StartGameAction;
    public void GoToMenu()
    {
        GoToMenuAction?.Invoke();
    }

    public void StartGame()
    {
        StartGameAction?.Invoke();
    }

}
