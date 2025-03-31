using Oculus.Interaction;
using UnityEngine;

public class DrillBodyCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        PlankCollider plank = other.gameObject.GetComponentInChildren<PlankCollider>();
        Debug.Log("Trigger 2 Enter");
        if (other.tag == "Plank" && plank.isTouching == true && plank.isJoinable == false)
        {
            Debug.Log("Trigger 2 Enter Plank");
            plank.isJoinable = true;
            plank.isChild = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlankCollider plank = other.gameObject.GetComponentInChildren<PlankCollider>();
        Debug.Log("Trigger 2 Exit");
        if (other.tag == "Plank")
        {
            Debug.Log("Trigger 2 Exit Plank");
            plank.isJoinable = false;
            plank.isChild = false;
        }
    }
}
