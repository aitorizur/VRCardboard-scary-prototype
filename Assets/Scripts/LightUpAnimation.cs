using UnityEngine;
using System.Collections;

public class LightUpAnimation : MonoBehaviour
{
    [SerializeField] private Light targetLight;

    [SerializeField] private float targetIntensity = 50;
    [SerializeField] private float lightUpTime = 2;

    private void Awake()
    {
        targetLight.intensity = 0.0f;
    }

    public void StartLightUpAnimation()
    {
        StartCoroutine(LightUp());
    }

    private IEnumerator LightUp()
    {
        while (targetLight.intensity < targetIntensity)
        {
            targetLight.intensity += Time.deltaTime / lightUpTime;
            yield return null;
        }

        targetLight.intensity = targetIntensity;
    }
}
