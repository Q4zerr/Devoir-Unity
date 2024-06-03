using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using Platformer.Mechanics;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Tilemaps;
using static Platformer.Core.Simulation;

public class ExplosionTrigger : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float explosionDelay;
    private Vector3 explosionPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerController>();
        if (player != null && player.health.IsAlive)
        {
            Schedule<PlayerDeath>();
            StartCoroutine(Explode());
        }

        if (other.GetComponent<TilemapCollider2D>() != null)
        {
            StartCoroutine(Explode());
        }
    }

    IEnumerator Explode()
    {
        yield return null;
        explosionPosition = transform.position;
        yield return new WaitForSeconds(explosionDelay);
        Instantiate(explosionPrefab, explosionPosition, transform.rotation);
        Destroy(gameObject);
    }
}
