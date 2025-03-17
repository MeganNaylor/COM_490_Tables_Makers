using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PowerDrill : MonoBehaviour
{
    public Collider drillBit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        drillBit.isTrigger = false;
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Drill);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drill(ActivateEventArgs arg)
    {
        drillBit.isTrigger = true;
    }
}
