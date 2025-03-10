using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyButtons : MonoBehaviour
{
    public GameObject collectible;
    private float remainingTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (collectible == null)
        // {
        //     Destroy(gameObject);
        // }

        // if (remainingTime > 0)
        // {
        //     remainingTime -= Time.deltaTime;
        // }
        
        // else if (remainingTime < 0)
        // {
        //     remainingTime = 0;
        //     Destroy(gameObject);
        // }
    }
}
