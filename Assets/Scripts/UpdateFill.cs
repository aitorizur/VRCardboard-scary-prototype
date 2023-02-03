using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UpdateFill : MonoBehaviour
{
    [SerializeField] private Image fillImage = null;
    public UnityEvent eventTest = null;

    public void SetFillImage(float amount)
    {
        fillImage.fillAmount = amount;    
    }
}
