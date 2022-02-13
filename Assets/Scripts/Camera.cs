using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] private Vector2 RefResolution;

    private void Start()
    {
        float refAspect = RefResolution.x / RefResolution.y;
        float scaleMultiplier = refAspect / UnityEngine.Camera.main.aspect;
        float newSize = UnityEngine.Camera.main.orthographicSize * scaleMultiplier;

        UnityEngine.Camera.main.orthographicSize = newSize;



    }


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 2, 0, -10);
    }
}
