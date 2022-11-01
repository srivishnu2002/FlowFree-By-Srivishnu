using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeInfo : MonoBehaviour
{
    public List<GameObject> Node1 = new List<GameObject>();
    public List<GameObject> Node2 = new List<GameObject>();
    public List<GameObject> Node3 = new List<GameObject>();
    public List<GameObject> Node4 = new List<GameObject>();
    public GameObject nodeObj;
    public GameObject nodeObj1;
    public GameObject nodeObj2;
    public GameObject nodeObj3;
    public bool test;
    public MoveCursor mc;
    public string prevNode;
    public string prevprevNode;
    public MakePath nodeObjmp;
    public GameObject EndPoint1;
    public GameObject EndPoint2;
    public GameObject EndPoint3;
    public GameObject EndPoint4;

    public Color c1;
    public Color c2;
    public Color c3;
    public Color c4;
    public Color highlighter;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nodeObj = GameObject.Find(Node1[Node1.Count - 1].transform.name);
        nodeObj1 = GameObject.Find(Node2[Node2.Count - 1].transform.name);
        nodeObj2 = GameObject.Find(Node3[Node3.Count - 1].transform.name);
        nodeObj3 = GameObject.Find(Node4[Node4.Count - 1].transform.name);

        GameObject.Find(EndPoint1.transform.name).transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
        GameObject.Find(EndPoint2.transform.name).transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
        //EndPoint2.transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
        Node1[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
        Node2[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
        //Node3[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c3;
        //Node4[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c4;

        
        //EndPoint3.transform.Find("Square").GetComponent<SpriteRenderer>().color = c3;
        //EndPoint4.transform.Find("Square").GetComponent<SpriteRenderer>().color = c4;

        nodeObj.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = true;
        nodeObj.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = true;
        nodeObj.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = true;
        nodeObj.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = true;

        nodeObj1.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect1 = true;
        nodeObj1.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect1 = true;
        nodeObj1.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect1 = true;
        nodeObj1.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect1 = true;

        /*nodeObj2.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj2.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj2.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj2.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect2 = true;

        nodeObj3.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect3 = true;*/
        /*if (Node1.Count > 0)
        {
            Node1[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
            EndPoint1.transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
            nodeObj = GameObject.Find(Node1[Node1.Count - 1].transform.name);

            nodeObj.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = true;
            nodeObj.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = true;
            nodeObj.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = true;
            nodeObj.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = true;

            
        }

       
            
        
        /*Node1[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
        EndPoint1.transform.Find("Square").GetComponent<SpriteRenderer>().color = c1;
        nodeObj = GameObject.Find(Node1[Node1.Count - 1].transform.name);*/





        /*if (Node3.Count > 0)
        {
            Node3[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
            EndPoint3.transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
            nodeObj2 = GameObject.Find(Node3[Node3.Count - 1].transform.name);
        }

        if(Node4.Count > 0)
        {
            Node4[0].transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
            EndPoint4.transform.Find("Square").GetComponent<SpriteRenderer>().color = c2;
            nodeObj3 = GameObject.Find(Node4[Node4.Count - 1].transform.name);
        }*/



        nodeObjmp = nodeObj.transform.GetComponent<MakePath>();



        if (Node1.Count >= 2)
        {
            prevNode = GameObject.Find(Node1[Node1.Count - 2].transform.name).transform.name;
        }
        
        if(Node1.Count >= 3)
        {

            /*if (nodeObj == Node1[Node1.Count - 3])
            {
                //stringtest = nodeObj.transform.name;
                //test = true;
                Node1[Node1.Count - 2].transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
            }*/
            //prevprevNode = GameObject.Find(Node1[Node1.Count - 3].transform.name).transform.name;

            if (Node1[Node1.Count - 1] == Node1[Node1.Count - 3])
            {
                Node1[Node1.Count - 2].transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
            }

        }



        //mc.CursorColor = nodeObj.transform.Find("Square").GetComponent<SpriteRenderer>().color;
        

        

        

        nodeObj3.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj3.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj3.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect2 = true;
        nodeObj3.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect2 = true;

        nodeObj3.GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect3 = true;
        nodeObj3.GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect3 = true;



        /*Node2[0].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = true;
        Node2[0].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = true;
        Node2[0].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = true;
        Node2[0].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = true;
        

        Node3[0].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = true;
        Node3[0].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = true;
        Node3[0].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = true;
        Node3[0].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = true;*/







    }
}
