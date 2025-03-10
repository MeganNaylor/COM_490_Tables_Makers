using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GrabObject : MonoBehaviour, IDragHandler
{
    public GameObject BuildSet;

    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {

        rectTransform = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / BuildSet.transform.position;
    }


}
