using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touche : MonoBehaviour
{
     [SerializeField]
     private GameObject bird;
     [SerializeField]
     private GameObject Pide_up;
     [SerializeField]
     private GameObject Pide_down;
     [SerializeField]
     private float speed = 1f;
     [SerializeField] private AudioSource audioSource;
     [SerializeField] private AudioClip flyClip, pingClip, dieadClip;
     private bool isTouche = false;

     public GameObject Panel;
     public GameObject playAgainButton;
     public GameObject quitButton;

     private float dirXUp;
     private float dirYUp;

     float upXRight;
     float upYRight;

     float upXLeft;
     float upYLeft;

     private float dirXDown;
     private float dirYDown;

     float downXRight;
     float downYRight;

     float downXLeft;
     float downYLeft;

     private void Start()
     {

     }
     // Update is called once per frame
     void Update()
     {
         transform.position += (Vector3.left * Time.deltaTime) * speed;


         // Check PipeUp
         dirXUp = Pide_up.transform.position.x;
         dirYUp = Pide_up.transform.position.y;


         upXLeft = dirXUp + 0.8f;
         upYLeft = dirYUp - 0.2f;

         upYRight = dirYUp - 0.2f;
         upXRight = dirXUp - 0.8f;


         if (bird.transform.position.x > upXRight && bird.transform.position.y > upYRight && bird.transform.position.x < upXLeft && bird.transform.position.y > upYLeft)
         {

             Time.timeScale = 0.0f;

             playAgainButton.SetActive(true);
             Panel.SetActive(true);
             quitButton.SetActive(true);
         }

         // Check PipeDown
         dirXDown = Pide_down.transform.position.x;
         dirYDown = Pide_down.transform.position.y;


         downXLeft = dirXDown + 0.8f;
         downYLeft = dirYDown + 0.2f;

         downYRight = dirYDown + 0.2f;
         downXRight = dirXDown - 0.8f;

         if (bird.transform.position.x > downXRight && bird.transform.position.y < downYRight && bird.transform.position.x < downXLeft && bird.transform.position.y < downYLeft)
         {

             Time.timeScale = 0.0f;

             playAgainButton.SetActive(true);
             Panel.SetActive(true);
             quitButton.SetActive(true);
         }   
     }
  /*  [SerializeField]
    private GameObject GameButton;

    [SerializeField]
    private List<GameObject> Pipe_up;
    [SerializeField]
    private List<GameObject> Pipe_down;

    private float SpaceBird;

    private float dirPipeUpLeft;
    private float dirPipeUpRight;
    private float dirPipeUpCenter;

    private float dirPipeDownLeft;
    private float dirPipeDownRight;
    private float dirPipeDownCenter;

    private float dirUp;
    private float dirDown;
    private float dirLeft;
    private float dirRight;

    int count = 0;

    private void Update()
    {
        ThisPosition(transform, 0.2f, 0.2f, 0.2f, 0.2f);
        SpaceBird = Space(transform, 2f);

        if (Pipe_up[count].transform.position.x < dirLeft - 1f)
        {
            count++;
            if (count == 3)
            {
                count = 0;
            }
        }
        Debug.Log(count);
        if (Pipe_up[count].transform.position.x < SpaceBird && Pipe_up[count].transform.position.x > dirLeft - 1f)
        {
            CheckPipeUp(0.6f, 0.6f);
            CheckPipeDown(0.6f, 0.6f);
        }
    }
    public virtual void ThisPosition(Transform Pos, float up, float down, float left, float right)
    {
        dirUp = Pos.position.y + up;
        dirDown = Pos.position.y - down;
        dirLeft = Pos.position.x - left;
        dirRight = Pos.position.x + right;
    }

    public virtual float Space(Transform Pos, float Space)
    {
        return Pos.position.x + Space;
    }
    private void CheckPipeUp(float left, float right)
    {
        dirPipeUpLeft = Pipe_up[count].transform.position.x - left;
        dirPipeUpRight = Pipe_up[count].transform.position.x + right;
        dirPipeUpCenter = Pipe_up[count].transform.position.y;

        if (dirRight > dirPipeUpLeft && dirUp > dirPipeUpCenter && dirLeft < dirPipeUpRight && transform.position.x == 0)
        {
            transform.position = new Vector3(Pipe_up[count].transform.position.x, Pipe_up[count].transform.position.y, 0);
            GameButton.SetActive(true);
        }
    }
    private void CheckPipeDown(float left, float right)
    {
        dirPipeDownLeft = Pipe_down[count].transform.position.x - left;
        dirPipeDownRight = Pipe_down[count].transform.position.x + right;
        dirPipeDownCenter = Pipe_down[count].transform.position.y;

        if (dirRight > dirPipeDownLeft && dirDown < dirPipeDownCenter && dirLeft < dirPipeDownRight && transform.position.x == 0)
        {
            transform.position = new Vector3(Pipe_down[count].transform.position.x, Pipe_down[count].transform.position.y, 0);
        }
    }*/
}
