using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{


    public GameObject platformPrefab;

    public int numberOfPlatforms = 100;
    public float LevelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;



    // Start is called before the first frame update
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
         {

            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-LevelWidth, LevelWidth);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
