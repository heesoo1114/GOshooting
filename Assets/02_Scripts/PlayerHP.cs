using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    [SerializeField] float maxHP = 10;
    float currentHP;
    SpriteRenderer spriteRenderer;
    PlayerController playerController;
    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    /*public float MaxHP 
    {
       
        get 
        { 
            return maxHP; 
        } 
    
    }
    
    public float CurrentHP
    {
        get
        {
            return currentHP;
        }
    }*/
    
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAniamation");

        if ( currentHP <= 0)
        {
            playerController.Die();
        }
    }

    IEnumerator HitColorAniamation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        spriteRenderer.color = Color.white;
    }
}
