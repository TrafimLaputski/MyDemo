using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] UIManager UI;
    int points;
    private void Start()
    {
        player.DeadAction += Save;
    }
    void Save()
    {
        points = UI.Point;

            if (points > PlayerPrefs.GetInt("MaxResult"))
            {
                PlayerPrefs.SetInt("MaxResult", points);
            }
    }

        public int MaxPoins
        {
            get
            {
                return (PlayerPrefs.GetInt("MaxResult"));
            }
        }
}

