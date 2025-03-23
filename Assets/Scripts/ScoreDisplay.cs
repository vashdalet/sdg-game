using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private GameObject trashBin;
    private GarbageCan garbageCan;
    private int scoreNumber;
    void Start()
    {
        // trashBin = GameObject.FindGameObjectWithTag("TrashBin");
        // garbageCan = trashBin.GetComponent<GarbageCan>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreNumber = GarbageCan.totalGarbage;
        scoreText.text = scoreNumber.ToString();
    }
}
