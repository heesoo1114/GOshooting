using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryProjectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy(collision.gameObject);
            collision.GetComponent<DestroyEnemy>().Die();
            Destroy(gameObject);
        }
    }

    
}
