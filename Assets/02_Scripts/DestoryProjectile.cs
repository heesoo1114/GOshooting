using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryProjectile : MonoBehaviour
{

    
    ObjectPooler bulletPooler; // 풀링

    private void Start()
    {
        bulletPooler = GameObject.Find("Player").GetComponent<ObjectPooler>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy(collision.gameObject);
            collision.GetComponent<DestroyEnemy>().Die();
            // Destroy(gameObject);
            bulletPooler.SpawnObject(transform.position, Quaternion.identity); // 풀링
        }
    }

    
}
