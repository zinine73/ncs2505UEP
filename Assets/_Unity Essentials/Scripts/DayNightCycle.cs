using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The duration of a full day-night cycle in real-world seconds.")]
    public float dayLengthSeconds = 60f; 

    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = 360f / dayLengthSeconds;
    }

    void Update()
    {
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
