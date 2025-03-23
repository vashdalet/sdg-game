using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    public static int scoreLevel1;
    public static int scoreLevel2;
    private GameObject trashBinObject;
    private GarbageCan trashBinScript;
    private GameObject shipObject;
    private ShipMovement shipScript;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // if (SceneManager.GetActiveScene().name == "Level 1")
        // {
        //     trashBinObject = GameObject.FindGameObjectWithTag("TrashBin");
        //     trashBinScript = trashBinObject.GetComponent<GarbageCan>();
        // }
        // if (SceneManager.GetActiveScene().name == "Level 2")
        // {
        //     shipObject = GameObject.FindGameObjectWithTag("Ship");
        //     shipScript = shipObject.GetComponent<ShipMovement>();
        // }
    } 
    void Update()
    {
       if (SceneManager.GetActiveScene().name == "Level 1")
        {
            scoreLevel1 = GarbageCan.totalGarbage;
        } 
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            scoreLevel2 = ShipMovement.itemsCollected;
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
