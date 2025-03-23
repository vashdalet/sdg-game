using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScoreLevel1Display : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int scoreNumber = SceneController.scoreLevel1;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNumber.ToString();
    }
}
