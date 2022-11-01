using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerParant : MonoBehaviour
{
   
    public NodeManager nm;
    //public GameObject EndPoint;
    // Start is called before the first frame update
    public int poinerNum;

    void Start()
    {
       
        nm = GameObject.Find("Node Manager").GetComponent<NodeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(poinerNum == 1)
        {
            transform.SetParent(nm.currentNode1.transform, false);

            if(nm.currentNode1 == nm.EndPoint1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = nm.smilyFace;
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
            
        }

        if (poinerNum == 2)
        {
            transform.SetParent(nm.currentNode2.transform, false);

            if (nm.currentNode2 == nm.EndPoint2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = nm.smilyFace;
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }

        }

        if (poinerNum == 3)
        {
            transform.SetParent(nm.currentNode3.transform, false);

            if (nm.currentNode3 == nm.EndPoint3)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = nm.smilyFace;
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }

        if (poinerNum == 4)
        {
            transform.SetParent(nm.currentNode4.transform, false);

            if (nm.currentNode4 == nm.EndPoint4)
            {
                
                gameObject.GetComponent<SpriteRenderer>().sprite = nm.smilyFace;
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;

            }

        }

        



    }
}
