using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballGenerator : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform spawnPoint;
    public float spawnRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFireball());
    }

    // Function to genarate fireball
    IEnumerator SpawnFireball()
    {
        while (true)
        {
            Instantiate(fireballPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
