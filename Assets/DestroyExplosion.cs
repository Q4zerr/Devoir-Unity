using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyObject());
    }

    // Destroy explosion
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
