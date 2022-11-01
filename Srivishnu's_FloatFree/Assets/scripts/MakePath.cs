using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePath : MonoBehaviour
{
    // Start is called before the first frame update
    //public bool IsNode;
    public bool StartNode;
    public Color StartNodeColor;
    public bool canSelect;
    public bool canSelect1;
    public bool canSelect2;
    public bool canSelect3;
    public bool FinishNode;

    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public List<GameObject> blockList = new List<GameObject>();
    public List<GameObject> PrevNode = new List<GameObject>();
    public List<GameObject> CurrentPath = new List<GameObject>();
    public string pathColor;
    public GameObject cursor1;
    public GameObject cursor2;
    public NodeCursor nc;
    public NodeInfo ni;
    //public List<string> canBeColor = new List<string>();
    private Vector3 touchPosition;
    


    void Start()
    {
       /* blockList.Add(block1);
        blockList.Add(block2);
        blockList.Add(block3);
        blockList.Add(block4);
        if (StartNode == true)
        {
            //IsNode = true;
            //ni.Node1.Add(transform.gameObject);
            StartNodeColor = transform.Find("Square").GetComponent<SpriteRenderer>().color;
            PrevNode.Add(transform.gameObject);
            //cursor.transform.GetComponent<storePathData>().pathList.Add(pathColor);
            
        }

        ni = GameObject.Find("Node Info").GetComponent<NodeInfo>();*/

    }

    // Update is called once per frame
    void Update()
    {

        /*if (transform.gameObject == ni.nodeObj)
        {
            transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.red;

        }
        else
        {
            transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
        }*/

        /*if(IsNode == true)
        {
            block1.transform.GetComponent<MakePath>().canSelect = true;
            block2.transform.GetComponent<MakePath>().canSelect = true;
            block3.transform.GetComponent<MakePath>().canSelect = true;
            block4.transform.GetComponent<MakePath>().canSelect = true;
            block1.transform.GetComponent<MakePath>().canBeColor.Add(canBeColor[0]);
            block2.transform.GetComponent<MakePath>().canBeColor.Add(canBeColor[0]);
            block3.transform.GetComponent<MakePath>().canBeColor.Add(canBeColor[0]);
            block4.transform.GetComponent<MakePath>().canBeColor.Add(canBeColor[0]);

        }

        else
        {
            block1.transform.GetComponent<MakePath>().canSelect = false;
            block2.transform.GetComponent<MakePath>().canSelect = false;
            block3.transform.GetComponent<MakePath>().canSelect = false;
            block4.transform.GetComponent<MakePath>().canSelect = false;
            block1.transform.GetComponent<MakePath>().canBeColor.Clear();
            block2.transform.GetComponent<MakePath>().canBeColor.Clear();
            block3.transform.GetComponent<MakePath>().canBeColor.Clear();
            block4.transform.GetComponent<MakePath>().canBeColor.Clear();
        }*/

        

        

    }

    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "cursor1")
        {
            
            if (canSelect == true)
            {
                //nc = collision.transform.GetComponent<NodeCursor>();
                //if(collision.transform.name == canBeColor[0])
                //{
                    CurrentPath.Add(transform.gameObject);

                //transform.Find("Square").GetComponent<SpriteRenderer>().color = collision.transform.GetComponent<MoveCursor>().CursorColor;
                    //transform.Find("Square").GetComponent<SpriteRenderer>().color = ni.Node1[ni.Node1.Count - 1].transform.Find("Square").GetComponent<SpriteRenderer>().color;

                if(ni.nodeObj != ni.EndPoint1)//|| ni.nodeObj != ni.EndPoint2 || ni.nodeObj != ni.EndPoint3 || ni.nodeObj != ni.EndPoint4)
                {
                    ni.Node1.Add(transform.gameObject);
                }

                





                                                                    /*block1.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                                                                    block2.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                                                                    block3.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                                                                    block4.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;*/



                /*ni.Node1[ni.Node1.Count - 2].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = false;
                    ni.Node1[ni.Node1.Count - 2].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = false;
                    ni.Node1[ni.Node1.Count - 2].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = false;
                    ni.Node1[ni.Node1.Count - 2].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = false;

                    




                //IsNode = true;
                nc.nodePos = transform.position;
                //}
                
                

            }

            if (canSelect1 == true)
            {
                //nc = collision.transform.GetComponent<NodeCursor>();
                //if(collision.transform.name == canBeColor[0])
                //{
                CurrentPath.Add(transform.gameObject);

                //transform.Find("Square").GetComponent<SpriteRenderer>().color = collision.transform.GetComponent<MoveCursor>().CursorColor;
                //transform.Find("Square").GetComponent<SpriteRenderer>().color = ni.Node1[ni.Node1.Count - 1].transform.Find("Square").GetComponent<SpriteRenderer>().color;

                if (ni.nodeObj1 != ni.EndPoint2)//|| ni.nodeObj != ni.EndPoint2 || ni.nodeObj != ni.EndPoint3 || ni.nodeObj != ni.EndPoint4)
                {
                    ni.Node2.Add(transform.gameObject);
                }







                            /*block1.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                            block2.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                            block3.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                            block4.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;*/



                /*ni.Node2[ni.Node1.Count - 2].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node2[ni.Node1.Count - 2].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node2[ni.Node1.Count - 2].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node2[ni.Node1.Count - 2].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = false;






                //IsNode = true;
                nc.nodePos = transform.position;
                //}



            }

            if (canSelect2 == true)
            {
                //nc = collision.transform.GetComponent<NodeCursor>();
                //if(collision.transform.name == canBeColor[0])
                //{
                CurrentPath.Add(transform.gameObject);

                //transform.Find("Square").GetComponent<SpriteRenderer>().color = collision.transform.GetComponent<MoveCursor>().CursorColor;
                //transform.Find("Square").GetComponent<SpriteRenderer>().color = ni.Node1[ni.Node1.Count - 1].transform.Find("Square").GetComponent<SpriteRenderer>().color;

                if (ni.nodeObj2 != ni.EndPoint3)//|| ni.nodeObj != ni.EndPoint2 || ni.nodeObj != ni.EndPoint3 || ni.nodeObj != ni.EndPoint4)
                {
                    ni.Node3.Add(transform.gameObject);
                }







                /*block1.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block2.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block3.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block4.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;*/



                /*ni.Node3[ni.Node1.Count - 2].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node3[ni.Node1.Count - 2].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node3[ni.Node1.Count - 2].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node3[ni.Node1.Count - 2].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = false;






                //IsNode = true;
                nc.nodePos = transform.position;
                //}



            }

            if (canSelect3 == true)
            {
                //nc = collision.transform.GetComponent<NodeCursor>();
                //if(collision.transform.name == canBeColor[0])
                //{
                CurrentPath.Add(transform.gameObject);

                //transform.Find("Square").GetComponent<SpriteRenderer>().color = collision.transform.GetComponent<MoveCursor>().CursorColor;
                //transform.Find("Square").GetComponent<SpriteRenderer>().color = ni.Node1[ni.Node1.Count - 1].transform.Find("Square").GetComponent<SpriteRenderer>().color;

                if (ni.nodeObj3 != ni.EndPoint4)//|| ni.nodeObj != ni.EndPoint2 || ni.nodeObj != ni.EndPoint3 || ni.nodeObj != ni.EndPoint4)
                {
                    ni.Node4.Add(transform.gameObject);
                }







                /*block1.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block2.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block3.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;
                block4.transform.Find("Square").GetComponent<SpriteRenderer>().color = Color.white;*/



                /*ni.Node4[ni.Node1.Count - 2].GetComponent<MakePath>().block1.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node4[ni.Node1.Count - 2].GetComponent<MakePath>().block2.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node4[ni.Node1.Count - 2].GetComponent<MakePath>().block3.transform.GetComponent<MakePath>().canSelect = false;
                ni.Node4[ni.Node1.Count - 2].GetComponent<MakePath>().block4.transform.GetComponent<MakePath>().canSelect = false;






                //IsNode = true;
                nc.nodePos = transform.position;
                //}



            }



        }

       


    }*/
}
