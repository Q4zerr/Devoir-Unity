using UnityEngine;

public class MovingToken : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance = 2.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
    }
}
