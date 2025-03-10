using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private float speed = 8f;
    public int itemsInHands;
    private GameObject currentCollision;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal * speed, vertical * speed);

        if(currentCollision != null && Input.GetKeyDown(KeyCode.J) && itemsInHands < 2)
        {
            itemsInHands++;
            Destroy(currentCollision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Collectible")
        {
            currentCollision = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Collectible")
        {
            currentCollision = null;
        }
    }
}
