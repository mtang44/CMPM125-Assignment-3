using Unity.VisualScripting;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public GameObject DemoEffect;
    private bool isActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Interact()
    {
        if(!isActive)
        {
            isActive = true;
            DemoEffect.gameObject.SetActive(true);
        }
        else
        {
            isActive = false;
            DemoEffect.gameObject.SetActive(false);
        }
    }
}
