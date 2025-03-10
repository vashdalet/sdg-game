using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    public int totalGarbage = 0;
    private GameObject player;
    private PlayerMovement playerScript;
    public GameObject Jbutton;

    void Update()
    {
        if(player != null && Input.GetKeyDown(KeyCode.J))
        {
            totalGarbage += playerScript.itemsInHands;
            playerScript.itemsInHands = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player = collision.gameObject;
            playerScript = player.GetComponent<PlayerMovement>();
            Jbutton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player = null;
            Jbutton.SetActive(false);
        }
    }
}
