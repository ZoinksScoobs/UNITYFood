using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Item mouseCheck;

    public Camera main;

    public GameObject itemInspector;

	void Start ()
    {
        itemInspector = GameObject.FindGameObjectWithTag("ItemInspect");
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
	

	void Update ()
    {
		itemInspector.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
        /*if (mouseCheck.mouseOver == false)
        {
            itemInspector.SetActive(false);
        }
        else if (mouseCheck.mouseOver == true)
            {
                itemInspector.SetActive(true);
            }*/
    }
}
