using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    [SerializeField] float maxHP = 10;
    float currentHP;
    SpriteRenderer spriteRenderer;

    public float MaxHP 
    {
       
        get 
        { 
            return maxHP; 
        } 
    
    }
    
    public float CuurentHP
    {
        get
        {
            return currentHP;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAniamation");
    }

    IEnumerator HitColorAniamation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        spriteRenderer.color = Color.white;
    }
}
