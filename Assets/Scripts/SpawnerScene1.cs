using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScene1 : MonoBehaviour
{
    [SerializeField] private GameObject[] collectibles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnOnTheBeach());
    }

    IEnumerator SpawnOnTheBeach()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            int randomIndex = Random.Range(0, collectibles.Length);
            float randomYPos;
            float randomXPos = Random.Range(-8.0f, 8.5f);
            if (randomXPos < -6.0f)
            {
                randomYPos = Random.Range(1.2f, 3.0f); 
            }
            else
            {
                randomYPos = Random.Range(0.5f, 3.0f);
            }
            GameObject spawnedCollectible = Instantiate(collectibles[randomIndex]);
            spawnedCollectible.transform.position = new Vector3 (randomXPos, randomYPos, 0);
        }
    }
}
