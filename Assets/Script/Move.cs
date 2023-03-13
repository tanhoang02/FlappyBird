using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private bool isDash = false;
    private bool isSlow=false;

    private void Update()
    {
        if (-4 > transform.position.x)
        {
            transform.position = new Vector3(6.5f, Random.Range(-2, 2), 0);
        }
        transform.position += Vector3.left * Time.deltaTime * speed;
        if (!isDash)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                StartCoroutine(Dash());
            }
        }
        if (!isSlow)
        {
            if (Input.GetKey(KeyCode.J))
            {
                StartCoroutine(Slow());
            }
        }
        /*public GameObject Pipe;
        public float spawnRate = 1f;
        public float minheight = -1f;
        public float maxheight = 1f;
        void Start()
        {
            StartCoroutine(Spawners());
        }
        IEnumerator Spawners()
        {
            yield return new WaitForSeconds(2);
            Vector3 temp = Pipe.transform.position;
            temp.y = Random.Range(-2.5f, 2.5f);
            Instantiate(Pipe,temp,Quaternion.identity);
            StartCoroutine(Spawners());
        }*/

    }
    IEnumerator Dash()
    {
        isDash = true;
      //  transform.position += Vector3.left * speed * 10 * Time.deltaTime;
        speed+=7;
        yield return new WaitForSeconds(0.3f);
        isDash = false;
        transform.position += Vector3.left * speed * Time.deltaTime;
        speed-=7;
    }
    IEnumerator Slow()
    {
        isSlow = true;
        Time.timeScale =0.5f;
        yield return new WaitForSeconds(5f);
        isSlow = false;
        Time.timeScale = 1;
    }
}
