using UnityEngine;

public class PassTrigger : MonoBehaviour
{
    public LogicScript adder;
    // Start is called before the first frame update
    void Start()
    {
        adder = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            adder.AddScore(100);
        }
    }
    
}
