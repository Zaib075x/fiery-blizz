using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public GameObject fruit;
    public LogicScript logic;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset = 10;
    public float widthOffset = 10;  

    // Start is called before the first frame update
    void Start()
    {
        SpawnFruit();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnFruit();
            timer = 0;
        }

       }
    



    void SpawnFruit()
    {
        spawnRate = Random.Range(5, 15);
        float startingPoint = transform.position.x - widthOffset;
        float endingPoint = transform.position.x + widthOffset; 
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(fruit, new Vector3(Random.Range(startingPoint,endingPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided");
        logic.AddScore(500);
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        Destroy(gameObject);
    }


}
