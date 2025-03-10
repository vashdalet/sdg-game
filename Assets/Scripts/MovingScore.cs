using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.EditorTools;

public class MovingScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int scoreNumber;
    public GameObject targetObject;
    private ShipMovement targetScript;

    // Start is called before the first frame update
    void Start()
    {
        targetScript = targetObject.GetComponent<ShipMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreNumber = targetScript.itemsCollected;
        scoreText.text = scoreNumber.ToString();
    }

    void LateUpdate()
    {
        Vector3 objectiveScreenPos = targetObject.transform.position;
        gameObject.transform.position = objectiveScreenPos;
    }
}
