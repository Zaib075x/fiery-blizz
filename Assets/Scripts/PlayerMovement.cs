using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed;
    public LogicScript logic;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) == true || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && gameOver == false)
        {
            rb.velocity = Vector2.up * playerSpeed;
        }
        if(transform.position.y < -4.5 || transform.position.y > 4)
        {
            logic.GameOver();
            gameOver = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        gameOver = true;
    }
}
