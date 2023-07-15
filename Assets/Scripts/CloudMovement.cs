using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float cloudMoveSpeed = 2;
    private float _endPosX;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartFloating(float speed,float endPosX)
    {
        cloudMoveSpeed = speed;
        _endPosX = endPosX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * cloudMoveSpeed);
        if(transform.position.x < _endPosX)
        {
            Destroy(gameObject);
        }
               
    }

  
}
