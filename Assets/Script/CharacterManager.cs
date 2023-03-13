using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
 
    public CharacterDatabase characterDB;
    public Text nameText;
    public SpriteRenderer artworkSprite;
    public Animator anim;

    [SerializeField]
    private int selectedOption = 0;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOptions"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    private void UpdateCharacter(int selectedOption)
    {
        Character character= characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        anim.runtimeAnimatorController = character.CharacterRuntimeAnimatorController;
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOptions");
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOptions", selectedOption);
    }    
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
  
}
