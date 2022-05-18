using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteSpawner : MonoBehaviour
{

    [SerializeField] StageData stageData;
    [SerializeField] GameObject alterLinePrefab;
    [SerializeField] GameObject meteoritePrefab;
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnMeteorite");
    }

    IEnumerator SpawnMeteorite()
    {
        while(true)
        {
            float positionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);
            GameObject alterLineClone = Instantiate(alterLinePrefab, 
                new Vector3(positionX, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(1.0f);

            Destroy(alterLineClone);
           
            Vector3 meteoritePosition = new Vector3(positionX, stageData.LimitMax.y + 0.1f, stageData.LimitMin.y);
            Instantiate(meteoritePrefab, meteoritePosition, Quaternion.identity);

            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(spawnTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
