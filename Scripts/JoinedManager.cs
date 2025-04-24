using UnityEngine;

public class JoinedManager : MonoBehaviour
{
    //public bool isTouching;
    //Parent label
    public bool isParent;
    //Child label
    public bool isChild;
    //"This plank has been assigned" label
    public bool assigned;

    public ParentManager parentManager;
    //public PlankCollider plankCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //parentManager = GetComponent<ParentManager>();
        //isTouching = false;
        isParent = false;
        isChild = false;
        assigned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isParent)
        {
            parentManager.parent = this.gameObject;
        }
        else if (isChild)
        {
            parentManager.child = this.gameObject;
        }
        //else if (isParent)
        //{
        //    parentManager.parent = null;
        //}
        //else if (isChild)
        //{
        //    parentManager.child = null;
        //}
    }
}
