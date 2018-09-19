using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Usable : Item
{
    [Header("Use Function")]
    private float uses;
    public float maxUses;
    public string usedText;

    [Header("TMPro")]
    public GameObject popUpText;
    public float popUpTextSize;

    

    public void Awake()
    {
        uses = maxUses;
        
    }


    public void OnMouseUpAsButton()
    {
        Use();
    }

    public virtual void Use()
    {
        if (uses <= 0)
        {
            usedText = "No uses left.";
        }
        uses -= 1;
        print(UseText());
        GameObject newObject = Instantiate(popUpText, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        newObject.GetComponent<TextMeshPro>().fontSize = popUpTextSize;
        newObject.GetComponent<TextMeshPro>().SetText(usedText);
    }

    public virtual string UseText()
    {
        return "You consumed/Used " + DisplayName;
    }

    public virtual string cantUseText()
    {
        return "You can't consume/use " + DisplayName + " anymore.";
    }

    public override string ToString()
    {
        return base.ToString();
    }



}
