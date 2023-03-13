using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public CharacterDatabase characterDB;
    [SerializeField] private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    [SerializeField] private bool isAlive = true;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip flyClip, pingClip, dieadClip;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private static float Score = 0f;
    public Text scoreTxt;

    public SpriteRenderer artworkSprite;
    public Animator anim;

    [SerializeField]
    private int selectedOption = 0;

    private void Awake()
    {
        Score = 0f;
    }
    private void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOptions"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
      
       // sh = GetComponent<SoundHandler>();

    }
    private void Update()
    {
      //  Horizontal = Input.GetAxisRaw("Horizontal");
       // Vertical = Input.GetAxisRaw("Vertical");
        Fly();
        Shot();
        IsAlive();
        //  sh.Playdie();

    }
    private void Shot()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Fire();
        }

    }
    private void Fly()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
            audioSource.PlayOneShot(flyClip);
        }
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;     
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, direction.y * 5f);
    }
    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        anim.runtimeAnimatorController = character.CharacterRuntimeAnimatorController;
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOptions");
    }
    private void Fire()
    {
        GameObject bullet = ObjectPool.instance.GetPooledPbject();
        if(bullet!= null)
        {
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
        }
    }
    private void IsAlive()
    {
        if (isAlive)
        {
            Score += Time.deltaTime * 0.4f;

            scoreTxt.text = "Score : " + Mathf.Round(Score).ToString();
        }
    }
    public static float AddScore()
    {
        return Score;
    }
}

