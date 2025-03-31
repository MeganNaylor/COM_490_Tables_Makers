using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PowerDrill : MonoBehaviour
{
    public BoxCollider DrillBit;
    //public SphereCollider LHandCollider;
    //public SphereCollider RHandCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrillBit.enabled = true;
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(PowerOnDrill);
        grabbable.deactivated.AddListener(PowerOffDrill);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerOnDrill(ActivateEventArgs args)
    {
        Debug.Log("Drill powered!");
        DrillBit.enabled = false;
    }
    void PowerOffDrill(DeactivateEventArgs args)
    {
        Debug.Log("Drill off!");
        DrillBit.enabled = true;
    }
}
