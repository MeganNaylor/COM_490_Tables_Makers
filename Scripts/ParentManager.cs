using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ParentManager : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;

    public DrillCollider drillCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        parent = null;
        child = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (parent != null && child != null)
        {
            XRGrabInteractable interactable = parent.GetComponent<XRGrabInteractable>();

            //foreach (Transform child in child.transform)
            //{
            //    Debug.Log(child.transform.name);

            //    interactable.colliders.Add(child.GetComponent<Collider>());

            //    child.transform.SetParent(parent.transform);

            //    Debug.Log(parent.name + " and " + child.name + " are now joined");
            //}

            int children = child.transform.childCount;
            for (int i = 0; i < children; i++)
            {
                //Using 0 because the first object on the list will be moved, and the next object will take its place
                //Using i does work, it just recieves an out of bounds error
                //Just use 0 to stay safe :)
                Debug.Log(child.transform.GetChild(0).name);

                interactable.colliders.Add(child.transform.GetChild(0).GetComponent<Collider>());
                Debug.Log("Move collider");

                child.transform.GetChild(0).transform.SetParent(parent.transform);
                Debug.Log("Move to new parent");
            }

            JoinedManager joinedManager = child.GetComponent<JoinedManager>();

            joinedManager.isChild = false;
            joinedManager.assigned = false;

            Destroy(child.gameObject);

            drillCollider.parentAssigned = false;
            drillCollider.childAssigned = false;

            parent = null;

            child = null;

            interactable.enabled = false;
            interactable.enabled = true;
        }
    }
}
