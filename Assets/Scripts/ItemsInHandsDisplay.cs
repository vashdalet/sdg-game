using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsInHandsDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public GameObject player;
    private PlayerMovement playerMovementScript;
    private int itemsInHands;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        itemsInHands = playerMovementScript.itemsInHands;
        scoreText.text = itemsInHands.ToString();
    }
}
