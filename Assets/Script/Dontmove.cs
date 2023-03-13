using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontmove : MonoBehaviour
{
    [SerializeField]private GameObject Pipe;

    // Update is called once per frame
    void Update()
    {
        Pipe.transform.position = new Vector3(10,0,0);
    }
}
