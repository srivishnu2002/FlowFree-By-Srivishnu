using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCursor : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 35f;
    public Color CursorColor;
    Vector3 difference = Vector3.zero;
    public NodeInfo ni;
    public NodeManager nm;

    public List<GameObject> canTouch = new List<GameObject>();
    public GameObject selectedNode;

    public bool isBlocked;


    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ni = GameObject.Find("Node Info").GetComponent<NodeInfo>();
        nm = GameObject.Find("Node Manager").GetComponent<NodeManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }

        }



    }

    private void OnMouseDown()
    {
        difference = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector3)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject == nm.currentNode1)
        {
            //CursorColor = nm.currentNode1.transform.Find("Square").GetComponent<SpriteRenderer>().color;
            selectedNode = nm.currentNode1;
            canTouch = nm.canTouch1;

        }

        else if (collision.transform.gameObject == nm.currentNode2)
        {
            //CursorColor = nm.currentNode1.transform.Find("Square").GetComponent<SpriteRenderer>().color;
            selectedNode = nm.currentNode2;
            canTouch = nm.canTouch2;

        }

        else if (collision.transform.gameObject == nm.currentNode3)
        {
            //CursorColor = nm.currentNode1.transform.Find("Square").GetComponent<SpriteRenderer>().color;
            selectedNode = nm.currentNode3;
            canTouch = nm.canTouch3;

        }

        else if (collision.transform.gameObject == nm.currentNode4)
        {
            //CursorColor = nm.currentNode1.transform.Find("Square").GetComponent<SpriteRenderer>().color;
            selectedNode = nm.currentNode4;
            canTouch = nm.canTouch4;

        }

        else
        {
            for(int i=0;i<nm.blockedList.Count;i++)
            {
                if(collision.transform.gameObject != nm.blockedList[i])
                {
                    isBlocked = false;
                }

                else
                {
                    isBlocked = true;
                    break;
                }
            }

            if(isBlocked == false)
            {
                for (int i = 0; i < canTouch.Count; i++)
                {
                    if (collision.transform.gameObject == canTouch[i])
                    {
                        if (selectedNode == nm.currentNode1)
                        {
                            if (nm.reachedEnd1 == false)
                            {
                                if (collision.transform.gameObject != nm.EndPoint2 && collision.transform.gameObject != nm.EndPoint3 && collision.transform.gameObject != nm.EndPoint4)
                                {
                                    nm.path1.Add(collision.transform.gameObject);
                                    selectedNode = collision.transform.gameObject;
                                    canTouch = nm.canTouch1;
                                    nm.updateTouchLists();
                                }

                            }

                        }

                        else if (selectedNode == nm.currentNode2)
                        {
                            if (nm.reachedEnd2 == false)
                            {
                                if (collision.transform.gameObject != nm.EndPoint1 && collision.transform.gameObject != nm.EndPoint3 && collision.transform.gameObject != nm.EndPoint4)
                                {
                                    nm.path2.Add(collision.transform.gameObject);
                                    selectedNode = collision.transform.gameObject;
                                    canTouch = nm.canTouch2;
                                    nm.updateTouchLists();
                                }

                            }
                        }

                        else if (selectedNode == nm.currentNode3)
                        {
                            if (nm.reachedEnd3 == false)
                            {
                                if (collision.transform.gameObject != nm.EndPoint1 && collision.transform.gameObject != nm.EndPoint2 && collision.transform.gameObject != nm.EndPoint4)
                                {
                                    nm.path3.Add(collision.transform.gameObject);
                                    selectedNode = collision.transform.gameObject;
                                    canTouch = nm.canTouch3;
                                    nm.updateTouchLists();
                                }


                            }
                        }

                        else if (selectedNode == nm.currentNode4)
                        {
                            if (nm.reachedEnd4 == false)
                            {
                                if (collision.transform.gameObject != nm.EndPoint1 && collision.transform.gameObject != nm.EndPoint2 && collision.transform.gameObject != nm.EndPoint3)
                                {
                                    nm.path4.Add(collision.transform.gameObject);
                                    selectedNode = collision.transform.gameObject;
                                    canTouch = nm.canTouch4;
                                    nm.updateTouchLists();
                                }

                            }
                        }
                    }
                }
            }
            
        }



    }
}


