using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnInterval = 1;
    public GameObject enemy;
    private float spawnTimer = 0;
    private float spawnX = 0;
    private float spawnZ = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnInterval <= spawnTimer)
        {
            spawnTimer = 0;
            spawnX = Random.Range(-10, 10);
            spawnZ = Random.Range(-10, 10);
            Instantiate(enemy, new Vector3(spawnX, 0.76f, spawnZ), Quaternion.identity);
            
        }
        spawnTimer += Time.deltaTime;
    }
}
