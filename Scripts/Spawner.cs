using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BombPrefab;
    public float secondsBetweenSpawns = 1;
    float nextSpawnTime;
    
    public Vector2 spawnSizeMinMax;

    Vector2  screenHalfSizeWorldUnits;

    // Start is called before the first frame update
    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            Vector2 spawnPosition = new Vector2(Random.Range (-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y + 0.5f);
            GameObject newBomb = (GameObject)Instantiate(BombPrefab, spawnPosition, Quaternion.identity);
            newBomb.transform.localScale = Vector2.one * spawnSize;

            if (Input.GetKeyDown("escape"))
            {
            Application.Quit();
            }

        }
    }
}
