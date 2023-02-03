using UnityEngine;
using UnityEngine.Events;

public class EventOnGaze : MonoBehaviour
{
    [SerializeField] private float timeForFullGaze = 1.0f;
    [SerializeField] private UnityEvent onFullGazed = null;
    [SerializeField] private UnityEvent<float> eventOnGaze = null;

    public float GazeTimeNormalized = 0.0f;

    private bool isBeingGazed = false;

    private void Update()
    {
        float gazeValue = isBeingGazed ? Time.deltaTime / timeForFullGaze : -Time.deltaTime / timeForFullGaze;
        GazeTimeNormalized = Mathf.Clamp(GazeTimeNormalized + gazeValue, 0.0f, 1.0f);
        eventOnGaze.Invoke(GazeTimeNormalized);
        if (GazeTimeNormalized >= 1.0f) onFullGazed.Invoke();
    }

    public void OnPointerEnter()
    {
        isBeingGazed = true;
    }

    public void OnPointerExit()
    {
        isBeingGazed = false;
    }
}
