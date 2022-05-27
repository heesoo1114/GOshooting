using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    TextMeshProUGUI textScore;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score : " + playerController.Score;
    }
}
