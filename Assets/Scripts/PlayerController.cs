using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 60f;
    public bool isGameOver = false;
    bool isJumping = true;
    public Weapon weapon;

    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGameOver)
        {
            weapon.Fire();
            isGameOver = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping && !isGameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isGameOver = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverMenu.gameObject.SetActive(true);
            isJumping = false;
            isGameOver = true;
            //Time.timeScale = 0;
            Destroy(this.gameObject);
            Debug.Log("Game Over");
            

        }


        if (collision.gameObject.CompareTag("Enemy"))
        {
            isJumping = false;
            //Time.timeScale = 0;
            Destroy(this.gameObject);
            Debug.Log("Game Over");
        }

        if (collision.gameObject.CompareTag("LowerBlock"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Obstacle"))
        //{
        //    isJumping = false;
        //    //Time.timeScale = 0;
        //    Debug.Log("Game Over");
        //}

        if (collision.gameObject.CompareTag("Points"))
        {
            ScoreScript.scoreValue += 1;
            Debug.Log("You scored!");
        }

    }
}
