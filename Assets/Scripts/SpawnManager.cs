using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] collectibleReference;
    // private GameObject spawnedCollectible;
    // private int randomIndex;
    // private float randomXPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTrash());
    }

    IEnumerator SpawnTrash()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            int randomIndex = Random.Range(0, collectibleReference.Length);
            float randomXPos = Random.Range(-8.0f, 8.0f);

            GameObject spawnedCollectible = Instantiate(collectibleReference[randomIndex]);

            spawnedCollectible.transform.position = new Vector3 (randomXPos, 6, 0);
            spawnedCollectible.GetComponent<CollectibleMovement>().needsToMove = true;
            spawnedCollectible.GetComponent<CollectibleMovement>().speed = Random.Range(4, 7);
        }
    }
}
