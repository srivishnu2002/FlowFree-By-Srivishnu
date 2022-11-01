using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{
    public int colorNum;
    public NodeManager nm;
    // Start is called before the first frame update
    void Start()
    {
        nm = GameObject.Find("Node Manager").GetComponent<NodeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        if(colorNum == 1 && nm.reachedEnd1 == true)
        {
            textmeshPro.SetText("RED : COMPLETE");
        }

        if (colorNum == 2 && nm.reachedEnd2 == true)
        {
            textmeshPro.SetText("GREEN : COMPLETE");
        }

        if (colorNum == 3 && nm.reachedEnd3 == true)
        {
            textmeshPro.SetText("BLUE : COMPLETE");
        }

        if (colorNum == 4 && nm.reachedEnd4 == true)
        {
            textmeshPro.SetText("PINK : COMPLETE");
        }
    }
}
