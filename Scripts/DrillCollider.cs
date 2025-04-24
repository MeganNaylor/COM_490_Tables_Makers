using Oculus.Interaction;
using UnityEditor.UI;
using UnityEngine;

public class DrillCollider : MonoBehaviour
{
    //Has the parent been assigned yet
    public bool parentAssigned;
    //Has the child been assigned yet
    public bool childAssigned;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        parentAssigned = false;
        childAssigned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plank")
        {
            JoinedManager parentObject = other.gameObject.GetComponentInParent<JoinedManager>();

            //If drill intersects a plank that is touching another plank and has not been assigned yet and parent has not been assigned yet
            if (parentObject.assigned == false && parentAssigned == false)
            {
                parentObject.isParent = true;
                parentAssigned = true;
                parentObject.assigned = true;
            }

            //If drill intersects a plank that is touching another plank and has not been assigned yet and child has not been assigned yet
            else if (parentObject.assigned == false)
            {
                parentObject.isChild = true;
                //childAssigned = true;
                parentObject.assigned = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Plank")
        {
            JoinedManager parentObject = other.gameObject.GetComponentInParent<JoinedManager>();
            if (parentObject.isParent == true)
            {
                parentObject.isParent = false;
                parentAssigned = false;
                parentObject.assigned = false;
            }
            else if (parentObject.isChild == true)
            {
                parentObject.isChild = false;
                //childAssigned = false;
                parentObject.assigned = false;
            }
        }
    }
}
