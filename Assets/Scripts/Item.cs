using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    [Header("Item aspects")]
    public string DisplayName;
    public float weight;
    public float cost;
    public string description;
    public bool mouseOver = false;

    [Header("Texts")]
    public GameObject nameText;
    public Text weightCost;
    public Text descriptionText;

    public void Update()
    {
         /*nameText.GetComponent<TextMeshPro>().SetText(DisplayName);*/
    }

    public float GetWeightPrice()
    {
        return cost / weight;
    }

    public override string ToString()
    {
        return DisplayName + ", It weights " + weight + " kilograms and costs " + GetWeightPrice().ToString("0.00") + " Kr per kg";
        //return base.ToString();
    }

    public virtual void OnMouseEnter()
    {
        Debug.Log("Heyyy, that's pretty cool");
        Debug.Log(ToString());
        MouseFollow.mouseCheck = this;
        
        //nameText.text = DisplayName;*/
    }

    public virtual void OnMouseExit()
    {
        MouseFollow.mouseCheck = null;
    }


}
