using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    GameManager manager;
    Vector3 StartPotition;
    Player player;
    UIManager UI;
    void Start()
    {
        StartPotition = transform.position;
        player = FindObjectOfType<Player>();
        manager = FindObjectOfType<GameManager>();
        UI = FindObjectOfType<UIManager>();
        NewPotition(0);
        manager.GoToMenuAction += StartMenu;
    }
    void Update()
    {
        if (player.transform.position.x - 5 >= transform.position.x)
        {
            NewPotition(50);
        }
    }


    private void NewPotition(int x)
    {
        float y = Random.Range(-2.25f, 2.25f);
        transform.position = new Vector3(transform.position.x + x, y, 1);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            UI.Point = 1;
        }
    }



    void StartMenu()
    {
        transform.position = StartPotition;
        NewPotition(0);
    }
}
