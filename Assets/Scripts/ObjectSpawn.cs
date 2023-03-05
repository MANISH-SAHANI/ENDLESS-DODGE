using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public float MaxX;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        startSpawn();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void spawn()
    {
        float randomX = Random.Range(-MaxX, MaxX);

        Vector2 randomSpawn = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, randomSpawn, Quaternion.identity);

    }

    void startSpawn()
    {
        InvokeRepeating("spawn", 1f, spawnRate);
    }

    void stopSwapn()
    {
        CancelInvoke("spawn");
    }
}
