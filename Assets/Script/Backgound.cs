using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgound : MonoBehaviour
{
    [Range(-1f, 1f)]
    [SerializeField] private float OffSet;
    [SerializeField] private Material mat;
    public float scrollspeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        OffSet += (Time.deltaTime * scrollspeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector3(OffSet, 0));
    }
}
