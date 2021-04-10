using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public InteractableAnim animObject;
    private VirtualButtonBehaviour virtualButton;
    public int option = 1;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animObject.UpdateAnimation(option);
        Debug.Log("Se presiono");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se levanto");
    }

    void Awake()
    {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(virtualButton != null)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }

    
}
