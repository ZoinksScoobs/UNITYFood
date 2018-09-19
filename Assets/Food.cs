using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{
    public string yummy;
    public float saturation;
    public bool isYummy;

    public override void Use()
    {
        base.Use();
    }

    public override string UseText()
    {
        return "You consumed/Used " + DisplayName + YummyToString();
    }

    public override string ToString()
    {
        return base.ToString() + YummyToString();
    }

    public string YummyToString()
    {
        if (isYummy == false)
            yummy = ", It is not yummy.";
        else if (isYummy == true)
            yummy = ", It is quite yummy.";
        else
            yummy = ", Not quite sure if it is yummy.";
        

        return yummy;
        
    }


}
