using UnityEngine;
using UnityEngine.UIElements;

public class ParentManager : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
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
            Debug.Log(parent.name + " and " + child.name + " are now joined");
            child.transform.SetParent(parent.transform);

            parent = null;
            child = null;
        }
    }
}
