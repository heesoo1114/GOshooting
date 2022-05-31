using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    [SerializeField] float damage = 1;
    [SerializeField] int scorePoint = 100;
    PlayerController playerController;
    [SerializeField] GameObject explosionPrefab;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();

        // ���� ������Ʈ �̸����� ã�� playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        // playerController = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerController>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            Die();
        }
    }

    public void Die()
    {
        playerController.Score += scorePoint;
        GameObject clone = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(clone.gameObject, 1f);
    }
}


        


 