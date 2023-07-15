using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleMovement : MonoBehaviour
{
    public float fruitSpeed = 5;
    public float fruitDeadZone = -8f;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * fruitSpeed) * Time.deltaTime;
        if (transform.position.x < fruitDeadZone)
        {
            Destroy(gameObject);
        }
    }


}
