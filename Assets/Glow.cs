using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float glowSpeed;
    public float glowIntensity;
    public float t;

    // Update is called once per frame
    void Update()
    {
        t = (Mathf.Sin(Time.time * glowSpeed) + 1) / 2;
        var superWhite = new Color(glowIntensity, glowIntensity, glowIntensity);
        spriteRenderer.color = Color.Lerp(Color.white, superWhite, t);
    }
}
