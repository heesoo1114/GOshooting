using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroy : MonoBehaviour
{

    ObjectPooler enemyPooler;
    ObjectPooler bulletPooler;
    [SerializeField] StageData stageData;
    float destroyWeight = 2f;

    private void Start()
    {
        bulletPooler = GameObject.Find("Player").GetComponent<ObjectPooler>();
        enemyPooler = GameObject.Find("EnemySpawner").GetComponent<ObjectPooler>();

    }

    private void LateUpdate()
    {
        
        if( transform.position.x > stageData.LimitMax.x + destroyWeight ||
            transform.position.y > stageData.LimitMax.y + destroyWeight ||
            transform.position.x < stageData.LimitMin.x - destroyWeight ||
            transform.position.y < stageData.LimitMin.y - destroyWeight)
        {
            if(gameObject.tag == "Bullet")
            {
                bulletPooler.ReturnObject(gameObject);
            }
            else if(gameObject.tag == "Enemy1")
            {
                enemyPooler.ReturnObject(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
