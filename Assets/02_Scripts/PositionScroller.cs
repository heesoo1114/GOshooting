using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScroller : MonoBehaviour
{

    [SerializeField] float scrollRange = 9.9f;
    [SerializeField] Transform target;

    private void Update()
    {
        /*
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(0, 10, 0);
        }
        */

        if(transform.position.y <= -scrollRange)
        {                                      // (0, 9.9, 0)
            transform.position = target.position + Vector3.up * scrollRange;
        }
    }
}
