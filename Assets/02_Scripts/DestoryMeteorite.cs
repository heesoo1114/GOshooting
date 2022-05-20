using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMeteorite : MonoBehaviour
{

    [SerializeField] float damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
