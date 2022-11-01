using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeCursor : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 10f;
    public Vector2 test1;
    public Vector2 test2;
    public Vector2 nodePos;
    public Color cursorColor;
    public GameObject CurrentNode;
    public NodeInfo ni;
    public int cursorNum;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if(cursorNum == 1)
        {
            CurrentNode = ni.Node1[0];
        }

        else if(cursorNum == 2)
        {
            CurrentNode = ni.Node2[0];
        }
        
        nodePos = CurrentNode.transform.position;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }

        else
        {
            transform.position = nodePos;

        }

    }
}
