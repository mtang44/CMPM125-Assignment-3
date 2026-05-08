using Unity.VisualScripting;
using UnityEngine;

public class ShieldInteractController : MonoBehaviour
{
    public GameObject ShieldBubble;
    private bool isActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void InteractShield()
    {
        if(!isActive)
        {
            isActive = true;
            ShieldBubble.gameObject.SetActive(true);
        }
        else
        {
            isActive = false;
            ShieldBubble.gameObject.SetActive(false);
        }
    }
}
