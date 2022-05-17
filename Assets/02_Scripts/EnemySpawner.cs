using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] StageData stagedata;
    [SerializeField] float spawnTime = 0.35f;
    [SerializeField] GameObject enemyPrefabs;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {

            float positionX = Random.Range(stagedata.LimitMin.x, stagedata.LimitMax.x);

            Instantiate(enemyPrefabs, new Vector3(positionX, stagedata.LimitMax.y + 1.0f, 0.0f), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);



        }
    }

}
