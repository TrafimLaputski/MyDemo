using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Player player;
    GameManager manager;
    Vector3 StartPotition;
    void Start()
    {
        
        StartPotition = transform.position;
        player = FindObjectOfType<Player>();
        manager = FindObjectOfType<GameManager>();
        manager.GoToMenuAction += StartMenu;
    }

   
    void Update()
    {
        if (transform.position.x + 240 <= player.transform.position.x )
        {
            NewPotition(480);
        }
    }

    void NewPotition(int x)
    {
        transform.position = new Vector2(transform.position.x + x, 0);
    }

    void StartMenu()
    {
        transform.position = StartPotition;
    }
    
}
