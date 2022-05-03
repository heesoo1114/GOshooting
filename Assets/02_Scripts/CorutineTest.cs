using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutineTest : MonoBehaviour
{

    public GameObject playerBullet;

    public void Start()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        while(true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(playerBullet, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                yield return new WaitForSeconds(0);
            }
        }
    }    




    void Update()
    {
        
    }
    

    
    
}
