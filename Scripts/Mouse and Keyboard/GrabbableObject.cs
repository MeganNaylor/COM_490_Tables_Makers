using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    public Transform playerCamera;
    bool beingCarried;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabObject()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        transform.parent = playerCamera;
        beingCarried |= true;
    }

    public void DropObject()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
    }
}
