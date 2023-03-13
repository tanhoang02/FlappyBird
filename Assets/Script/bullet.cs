using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 6f;
    private void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
}
