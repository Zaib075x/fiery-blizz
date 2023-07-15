using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMovement : MonoBehaviour
{
    public float iceSpeed = 5;
    public float deadZone = -8;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * iceSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

    }
}
