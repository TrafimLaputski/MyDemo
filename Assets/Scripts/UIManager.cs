using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] Text GamePoints;
    [SerializeField] Text MaxPoints;
    [SerializeField] Player player;
    [SerializeField] SaveManager SaveManager;
   
    
    [SerializeField] GameObject DeadMenuUI;
    [SerializeField] GameObject GameMenuUI;
    [SerializeField] GameObject StartMenuUI;
    [SerializeField] GameObject MaxResultUI;

    int points = 0;

    void Start()
    {
        
        GamePoints.text = "Points: " + points;
        player.DeadAction += DeadMenu;
        manager.GoToMenuAction += StartMenu;
        manager.StartGameAction += GameMenu;
        StartMenu();

    }
    public int Point
    {
        get
        {
            return points;
        }
        set
        {
            points += value;
            GamePoints.text = "Points: " + points;

        }
    }
  

    void DeadMenu()
    {

        DeadMenuUI.SetActive(true);

    }

    void StartMenu()
    {
        points = 0;
        DeadMenuUI.SetActive(false);
        GameMenuUI.SetActive(false);
        StartMenuUI.SetActive(true);
        MaxResultUI.SetActive(false);
    }

    void GameMenu()
    {
        StartMenuUI.SetActive(false);
        GameMenuUI.SetActive(true);
        GamePoints.text = "Points: " + points;
    }


   public void MaxResalt()
    {
        StartMenuUI.SetActive(false);
        MaxResultUI.SetActive(true);
        MaxPoints.text = ("Ваш максимальный результат: " + SaveManager.MaxPoins);
    }

}
