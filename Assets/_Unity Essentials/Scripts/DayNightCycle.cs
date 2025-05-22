using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField] private float dayDurationInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees for a full rotation
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X axis to simulate the sun moving across the sky
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
