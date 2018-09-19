using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public static Item mouseCheck;

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
        if (mouseCheck == false)
        {
            itemInspector.SetActive(false);
        }
        else if (mouseCheck == true)
            {
                itemInspector.SetActive(true);
            }
    }
}
