using UnityEngine;

public class PlankCollider : MonoBehaviour
{
    public bool isTouching;
    public bool isJoinable;
    public bool isParent;
    public bool isChild;

    public ParentManager parentManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isTouching = false;
        isJoinable = false;
        isParent = false;
        isChild = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouching && isJoinable && isParent)
        {
            Debug.Log(this.name + " is now parent");
            parentManager.parent = this.gameObject;
        }
        else if(isTouching && isJoinable && isChild)
        {
            parentManager.child = this.gameObject;
            Debug.Log(this.name + " is now child");
        }
        else if(isParent)
        {
            parentManager.parent = null;
        }
        else if(isChild)
        {
            parentManager.child = null;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plank")
        {
            isTouching = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Plank")
        {
            isTouching = false;
        }
    }
}
