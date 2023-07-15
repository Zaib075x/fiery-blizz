using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public LogicScript logic;
    public GameObject obs;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObs();
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {   SpawnObs();
            timer = 0;
        }
       

    }
    void SpawnObs()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(obs, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);

        if(logic.playerScore%800 == 0 && spawnRate > -1.5f)
        {
            spawnRate-=0.05f*Time.deltaTime;
        }

    }
    
}
