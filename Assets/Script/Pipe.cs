using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    //[SerializeField] private bool isDash = false;
    public float speed = 5f;
    private void Start()
    {    
    }
    private void Update()
    {
        transform.position += Vector3.left * speed* Time.deltaTime;
       // if (transform.position.x < leftEdge)
        {
        //    Destroy(gameObject);
        }
        //Press();
    }
    /*private void Press()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isDash == true)
            {}

        }
    }*/
   
    }
