using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NodeManager : MonoBehaviour
{
    public List<GameObject> path1 = new List<GameObject>();
    public List<GameObject> path2 = new List<GameObject>();
    public List<GameObject> path3 = new List<GameObject>();
    public List<GameObject> path4 = new List<GameObject>();

    public GameObject currentNode1;
    public GameObject currentNode2;
    public GameObject currentNode3;
    public GameObject currentNode4;

    public List<GameObject> canTouch1 = new List<GameObject>();
    public List<GameObject> canTouch2 = new List<GameObject>();
    public List<GameObject> canTouch3 = new List<GameObject>();
    public List<GameObject> canTouch4 = new List<GameObject>();

    public MakePath mp;

    public Color p1;
    public Color p2;
    public Color p3;
    public Color p4;

    public GameObject EndPoint1;
    public GameObject EndPoint2;
    public GameObject EndPoint3;
    public GameObject EndPoint4;

    public bool reachedEnd1;
    public bool reachedEnd2;
    public bool reachedEnd3;
    public bool reachedEnd4;

    public List<GameObject> blockedList = new List<GameObject>();

    public int pathNums;

    public Sprite smilyFace;

    





    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("updateTouchLists",0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        checkWinCondition();
        
        
        currentNode1 = path1[path1.Count - 1];
        currentNode2 = path2[path2.Count - 1];

        

        if(pathNums == 3)
        {
            currentNode3 = path3[path3.Count - 1];
        }
        
        if(pathNums == 4)
        {
            currentNode3 = path3[path3.Count - 1];
            currentNode4 = path4[path4.Count - 1];
        }
        

        UpdateBlockedList();

        EndPoint1.transform.Find("Square").GetComponent<SpriteRenderer>().color = p1;
        EndPoint2.transform.Find("Square").GetComponent<SpriteRenderer>().color = p2;
        if(pathNums == 3)
        {
            EndPoint3.transform.Find("Square").GetComponent<SpriteRenderer>().color = p3;
        }

        if(pathNums == 4)
        {
            EndPoint3.transform.Find("Square").GetComponent<SpriteRenderer>().color = p3;
            EndPoint4.transform.Find("Square").GetComponent<SpriteRenderer>().color = p4;
        }
        

        if (currentNode1 == EndPoint1)
        {
            reachedEnd1 = true;
        }

        if (currentNode2 == EndPoint2)
        {
            reachedEnd2 = true;
        }

        

        if(pathNums == 3)
        {
            if (currentNode3 == EndPoint3)
            {
                reachedEnd3 = true;
            }
        }

        if(pathNums == 4)
        {
            if (currentNode3 == EndPoint3)
            {
                reachedEnd3 = true;
            }

            if (currentNode4 == EndPoint4)
            {
                reachedEnd4 = true;
            }
        }
        

        updateTouchLists();

        for(int i=0;i<path1.Count;i++)
        {
            path1[i].transform.Find("Square").GetComponent<SpriteRenderer>().color = p1;
        }

        for (int i = 0; i < path2.Count; i++)
        {
            path2[i].transform.Find("Square").GetComponent<SpriteRenderer>().color = p2;
        }

        if(pathNums == 3)
        {
            for (int i = 0; i < path3.Count; i++)
            {
                path3[i].transform.Find("Square").GetComponent<SpriteRenderer>().color = p3;
            }
        }

        if(pathNums == 4)
        {
            for (int i = 0; i < path3.Count; i++)
            {
                path3[i].transform.Find("Square").GetComponent<SpriteRenderer>().color = p3;
            }

            for (int i = 0; i < path4.Count; i++)
            {
                path4[i].transform.Find("Square").GetComponent<SpriteRenderer>().color = p4;
            }
        }
        

    }

    public void updateTouchLists()
    {
        canTouch1.Clear();
        canTouch2.Clear();

        if(pathNums == 3)
        {
            canTouch3.Clear();
        }
        
        if(pathNums == 4)
        {
            canTouch3.Clear();
            canTouch4.Clear();
        }


        canTouch1.Add(currentNode1.transform.GetComponent<MakePath>().block1);
        canTouch1.Add(currentNode1.GetComponent<MakePath>().block2);
        canTouch1.Add(currentNode1.GetComponent<MakePath>().block3);
        canTouch1.Add(currentNode1.GetComponent<MakePath>().block4);

        canTouch2.Add(currentNode2.GetComponent<MakePath>().block1);
        canTouch2.Add(currentNode2.GetComponent<MakePath>().block2);
        canTouch2.Add(currentNode2.GetComponent<MakePath>().block3);
        canTouch2.Add(currentNode2.GetComponent<MakePath>().block4);

        if(pathNums == 3)
        {
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block1);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block2);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block3);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block4);
        }
        
        if(pathNums == 4)
        {
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block1);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block2);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block3);
            canTouch3.Add(currentNode3.GetComponent<MakePath>().block4);

            canTouch4.Add(currentNode4.GetComponent<MakePath>().block1);
            canTouch4.Add(currentNode4.GetComponent<MakePath>().block2);
            canTouch4.Add(currentNode4.GetComponent<MakePath>().block3);
            canTouch4.Add(currentNode4.GetComponent<MakePath>().block4);
        }



    }

    public void UpdateBlockedList()
    {
        blockedList.Clear();

        for(int i=0;i<path1.Count;i++)
        {
            blockedList.Add(path1[i]);
        }

        for (int i = 0; i < path2.Count; i++)
        {
            blockedList.Add(path2[i]);
        }

        if(pathNums == 3)
        {
            for (int i = 0; i < path3.Count; i++)
            {
                blockedList.Add(path3[i]);
            }
        }


        if(pathNums == 4)
        {
            for (int i = 0; i < path3.Count; i++)
            {
                blockedList.Add(path3[i]);
            }

            for (int i = 0; i < path4.Count; i++)
            {
                blockedList.Add(path4[i]);
            }
        }
        
    }

    public void checkWinCondition()
    {
        if (reachedEnd1 == true && reachedEnd2 == true)
        {
            if(pathNums < 3)
            {
                SceneManager.LoadScene("you win screen");
            }

            else if(pathNums == 3)
            {
                if(reachedEnd3 == true)
                {
                    SceneManager.LoadScene("you win screen");
                }
            }

            else if(pathNums == 4)
            {
                if (reachedEnd3 == true && reachedEnd4 == true)
                {
                    SceneManager.LoadScene("you win screen");
                }
            }
        }
    }

    

    

    
}
