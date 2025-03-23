using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public GameObject audioManager;
    private AudioManager audioManagerScript;
    private float horizontal;
    private Rigidbody2D rb;
    private float speed = 4;
    //private float xLeft = -10;
    //private float xRight = 10;

    public static int itemsCollected;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioManagerScript = audioManager.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); 
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Collectible")
        {
            audioManagerScript.PlaySFX(audioManagerScript.collecting);
            Destroy(collision.gameObject);
            itemsCollected++;
        }
    }
}
