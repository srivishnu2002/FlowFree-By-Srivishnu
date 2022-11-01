using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnNode : MonoBehaviour
{

    // Start is called before the first frame update
    public NodeManager nm;
    public bool t1;
    public bool t2;
    public bool t3;
    public bool t4;
    public bool startCheck;
    

    void Start()
    {
        nm = GameObject.Find("Node Manager").GetComponent<NodeManager>();
    }

    // Update is called once per frame
    void Update()
    {
            /*for (int i = 0; i < nm.canTouch1.Count; i++)
            {
                if (nm.canTouch1[i] == transform.gameObject)
                {
                    t1 = true;
                    break;
                }

                
            }

            for (int i = 0; i < nm.canTouch2.Count; i++)
            {
                if (nm.canTouch2[i] == transform.gameObject)
                {
                    t2 = true;
                    break;
                }

                
            }

            for (int i = 0; i < nm.canTouch1.Count; i++)
            {
                if (nm.canTouch3[i] == transform.gameObject)
                {
                    t3 = true;
                    break;
                }

                
            }

            for (int i = 0; i < nm.canTouch4.Count; i++)
            {
                if (nm.canTouch4[i] == transform.gameObject)
                {
                    t4 = true;
                    break;
                }

                
            }*/
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.name == "cursor")
        {
            
            if(t1 == true)
            {
                nm.path1.Add(transform.gameObject);
                nm.updateTouchLists();
            }

            else if (t2 == true)
            {
                nm.path2.Add(transform.gameObject);
                nm.updateTouchLists();
            }

            else if (t3 == true)
            {
                nm.path3.Add(transform.gameObject);
                nm.updateTouchLists();
            }

            else if (t4 == true)
            {
                nm.path4.Add(transform.gameObject);
                nm.updateTouchLists();
            }

        }
    }



}
