using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectibleMovement : MonoBehaviour
{
    public bool needsToMove = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (needsToMove == true)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lower Bound")
        {
            Destroy(gameObject);
        }
    }
}
