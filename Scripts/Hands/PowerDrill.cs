using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PowerDrill : MonoBehaviour
{
    //public SphereCollider LHandCollider;
    //public SphereCollider RHandCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(PowerOnDrill);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerOnDrill(ActivateEventArgs args)
    {
        Debug.Log("Drill Powered!");
        
    }
}
