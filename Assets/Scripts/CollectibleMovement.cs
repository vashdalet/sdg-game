using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleMovement : MonoBehaviour
{
    public bool needsToMove = false;
    public float speed;

    public GameObject button;
    static int timesToDisplay = 3;
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

        Debug.Log(timesToDisplay);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lower Bound")
        {
            Destroy(gameObject);
        }
        else if (collision.tag == "Player" && SceneManager.GetActiveScene().name == "Level 1" && timesToDisplay > 0)
        {
            timesToDisplay -= 1;
            GameObject spawnedButton = Instantiate(button);
            spawnedButton.transform.position = gameObject.transform.position;
            spawnedButton.transform.SetParent(gameObject.transform);
        }
    }

}
