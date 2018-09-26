using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DescCheck : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (MouseFollow.mouseCheck != null)
        {
                GetComponent<TextMeshPro>().SetText(MouseFollow.mouseCheck.description);

        }

    }

}
