using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPViewer : MonoBehaviour
{

    [SerializeField] PlayerHP playerHP;
    Slider sliderHP;

    
    // Start is called before the first frame update
    void Start()
    {
        sliderHP = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        sliderHP.value = playerHP.CurrentHP / playerHP.MaxHP;
    }
}
