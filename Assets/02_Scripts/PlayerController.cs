using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    KeyCode keyCodeAttack = KeyCode.Space;
    [SerializeField]
    StageData stageData;
    Movement movement;
    private Weapon weapon;
    
    Animator animator;
    bool isDie = false;

    int score;
    
    public int Score
    {
        set => score  =  Mathf.Max(0, value);
        get => score;
    
    }
        /*set
        {
            *//*if (value < 0) score = 0;
            else score = value;*//*
            score = Mathf.Max(0, value);    
        }

        get
        {
            return score;
        }*/
        
        
        
        
    

    void Awake()
    {
        movement = GetComponent<Movement>();
        weapon = GetComponent<Weapon>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        if (isDie) return;
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        movement.MoveTo(new Vector3(x, y, 0));

        if(Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if(Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y),
                                         0);
    }

    public void Die()
    {
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene("GameOver");
    }

    public void OnDieEnvent()
    {
        movement.MoveTo(Vector2.zero);
        animator.SetTrigger("onDie");
        Destroy(GetComponent<CircleCollider2D>());
        isDie = true;
    }
    
    
    /*
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.CompareTag("Meteorite"))
        {
            Destroy(collision.gameObject);
            
        }
    }
    */

}