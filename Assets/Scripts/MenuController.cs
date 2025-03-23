using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameObject sceneController;
    private SceneController sceneControllerScript;

    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameManager");
        sceneControllerScript = sceneController.GetComponent<SceneController>();
    }

    public void Retry()
    {
        SceneController.instance.LoadScene("Level 1");
        GarbageCan.totalGarbage = 0;
        ShipMovement.itemsCollected = 0;
    }
}
