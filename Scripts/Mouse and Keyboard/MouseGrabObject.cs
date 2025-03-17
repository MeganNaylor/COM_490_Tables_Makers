using UnityEngine;

public class MouseGrabObject : MonoBehaviour
{
    public GrabbableObject grabbableObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grabbableObject = GetComponent<GrabbableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f))
            {
                GrabbableObject grabbable = hit.transform.root.GetComponentInChildren<GrabbableObject>();
                if (grabbable)
                {
                    grabbableObject.GrabObject();
                }
            }
        }
        else
        {
            grabbableObject.DropObject();
        }
    }
}
