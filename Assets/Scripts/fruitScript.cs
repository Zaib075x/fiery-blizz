using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScript : MonoBehaviour
{
    public LogicScript logic;
    public GameObject fruitObj;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided");
        logic.AddScore(500);
        Destroy(fruitObj);
    }
}
