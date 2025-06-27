using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float obstacleSpeed = 8f;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isGameOver == false) 
        {
            transform.Translate(Vector2.left * Time.deltaTime * obstacleSpeed);
        }

    }
}
