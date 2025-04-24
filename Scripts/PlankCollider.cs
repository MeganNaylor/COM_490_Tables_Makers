//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit.Interactables;

//public class PlankCollider : MonoBehaviour
//{
    //Checks if two planks are touching
    //public bool isTouching;
    ////Parent label
    //public bool isParent;
    ////Child label
    //public bool isChild;
    ////"This plank has been assigned" label
    //public bool assigned;

    //public ParentManager parentManager;
    //public JoinedManager joinedManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    joinedManager = GetComponentInParent<JoinedManager>();
    //    //isTouching = false;
    //    //isParent = false;
    //    //isChild = false;
    //    //assigned = false;
    //}

    //// Update is called once per frame
    //void Update()
    //{
        //if(isTouching && isParent)
        //{
        //    parentManager.parent = this.gameObject;

        //}
        //else if(isTouching && isChild)
        //{
        //    parentManager.child = this.gameObject;
        //}
        //else if(isParent)
        //{
        //    parentManager.parent = null;
        //}
        //else if(isChild)
        //{
        //    parentManager.child = null;
        //}
//    }
//    private void OnCollisionStay(Collision collision)
//    {
//        GameObject plank1 = this.gameObject.GetComponentInParent<GameObject>();
//        GameObject plank2 = collision.gameObject.GetComponentInParent<GameObject>();
//        if (collision.gameObject.tag == "Plank" && plank1 != plank2)
//        {
//            joinedManager.isTouching = true;
//            Debug.Log(plank1 + " is touching " + plank2);
//        }
//    }
//    private void OnCollisionExit(Collision collision)
//    {
//        GameObject plank1 = this.gameObject.GetComponentInParent<GameObject>();
//        GameObject plank2 = collision.gameObject.GetComponentInParent<GameObject>();

//        if (collision.gameObject.tag == "Plank" && plank1 != plank2)
//        {
//            joinedManager.isTouching = false;
//        }
//    }
//}
