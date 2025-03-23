using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    public GameObject audioManager;
    private AudioManager audioManagerScript;
    public static int totalGarbage = 0;
    private GameObject player;
    private PlayerMovement playerScript;
    public GameObject Jbutton;

    void Start()
    {
        audioManagerScript = audioManager.GetComponent<AudioManager>();
    }
    void Update()
    {
        if(player != null && Input.GetKeyDown(KeyCode.J))
        {
            audioManagerScript.PlaySFX(audioManagerScript.trashbin);
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
