using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D PlayerBody;
    Vector2 Direction = new Vector2(1, 0);
    int SpeedUp = 0;
    float Speed = 0;
    public System.Action DeadAction;
   [SerializeField] GameManager manager;
    Vector3 StartPotition;
    void Start()
    {
        StartPotition = transform.position;
        PlayerBody = GetComponent<Rigidbody2D>();
        manager.GoToMenuAction += StartMenu;
        manager.StartGameAction += StartGame;
        StartMenu();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            PlayerBody.velocity = new Vector2(0, SpeedUp);


        }
    }
    void FixedUpdate()
    {
        transform.Translate(Direction * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe")
        {
            Dead();
        }

    }

    private void Dead()
    {
        DeadAction?.Invoke();
        Speed = 0;
        SpeedUp = 0;
        

    }

    void StartMenu()
    {
        
        transform.position = StartPotition;

        PlayerBody.isKinematic = true;
    }

    void StartGame()
    {

        PlayerBody.isKinematic = false;

        SpeedUp = 8;
        Speed = 3;
    }
}
