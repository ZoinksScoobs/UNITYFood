using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CostCheck : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {

        if (MouseFollow.mouseCheck != null)
        {
            if (MouseFollow.mouseCheck.cost > 0)
                GetComponent<TextMeshPro>().SetText("$ " + MouseFollow.mouseCheck.cost.ToString());
                
        }

    }
}
