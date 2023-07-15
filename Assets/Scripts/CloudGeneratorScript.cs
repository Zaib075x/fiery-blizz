using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
        Prewarm();
        Invoke("AttemptSpawn", spawnInterval);
    }

    void SpawnCloud(Vector3 startPos)
    {
        int randomIndex = Random.Range(0, clouds.Length);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        float startY = Random.Range(startPos.y - 1f, startPos.y + 1f);
        cloud.transform.position = new Vector3(startPos.x, startY, startPos.z);
        float scale = Random.Range(0.8f, 1.2f);
        cloud.transform.localScale = new Vector2(scale, scale);

        float speed = Random.Range(0.5f, 1.5f);
        cloud.GetComponent<CloudMovement>().StartFloating(speed, endPoint.transform.position.x);
    }

    void AttemptSpawn()
    {
        SpawnCloud(startPos);
        Invoke("AttemptSpawn",spawnInterval);
    }

    void Prewarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.left * (i * 2);
            SpawnCloud(startPos);
        }
    }











}



















    /*[SerializeField]
    GameObject[] clouds;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
        Invoke("AttemptSpawn",spawnInterval);
    }

    void SpawnCloud()
    {
        int randomIndex = Random.Range(0, clouds.Length);
        GameObject cloud = Instantiate(clouds[randomIndex]);

        spawnPosition.y = Random.Range(spawnPosition.y+1f, spawnPosition.y-1f);
        cloud.transform.position = spawnPosition;

        float scale = Random.Range(0.9f, 0.5f);
        cloud.transform.localScale = new Vector2(scale, scale);


        float speed = Random.Range(1.5f, 0.5f);
        //cloud.GetComponent<CloudMovement>().StartFloating(speed,endPoint.transform.position.x);
    }

    // Update is called once per frame
    void AttemptSpawn()
    {
        SpawnCloud();
        Invoke("AttemptSpawn", spawnInterval);
    }

}*/
