using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScoreLevel2Display : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int scoreNumber = SceneController.scoreLevel2;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNumber.ToString();
    }
}
