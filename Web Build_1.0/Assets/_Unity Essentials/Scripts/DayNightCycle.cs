using UnityEngine;

/// <summary>
/// Rotates a Directional Light around the X axis to simulate the sun moving across the sky.
/// Attach to your Directional Light.
/// </summary>
[RequireComponent(typeof(Light))]
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds a full in-game day (24 hours) lasts.")]
    [Min(0.01f)]
    public float dayLengthSeconds = 120f;

    [Tooltip("Current time of day. 0 = midnight, 0.25 = sunrise, 0.5 = noon, 0.75 = sunset.")]
    [Range(0f, 1f)]
    public float timeOfDay = 0.25f;

    [Tooltip("Compass direction (Y rotation) the sun rises from.")]
    [Range(0f, 360f)]
    public float sunDirection = 0f;

    [Tooltip("Uncheck to freeze time.")]
    public bool isRunning = true;

    void Update()
    {
        if (isRunning)
        {
            timeOfDay += Time.deltaTime / dayLengthSeconds;
            timeOfDay %= 1f;
        }

        ApplyRotation();
    }

    // Lets you scrub Time Of Day in the Inspector and see the result immediately, even outside Play mode.
    void OnValidate()
    {
        ApplyRotation();
    }

    void ApplyRotation()
    {
        // 0 -> -90° (sun below, pointing up), 0.25 -> 0° (horizon), 0.5 -> 90° (straight down at noon).
        float sunAngle = timeOfDay * 360f - 90f;
        transform.rotation = Quaternion.Euler(sunAngle, sunDirection, 0f);
    }
}
