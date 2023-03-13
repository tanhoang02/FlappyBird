using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class Abilities : MonoBehaviour
{
    [Header("Abilities 1")]
    public Image abilitiesImage1;
    public float cooldown1 = 5;
    bool isCooldown=false;
    public KeyCode abilities1;
    private void Start()
    {
        abilitiesImage1.fillAmount = 0;
    }
    void Update()
    {
        Abilities1();
    }
    private void Abilities1()
    {
        if(Input.GetKey(abilities1)&& isCooldown==false)
        {
            isCooldown= true;
            abilitiesImage1.fillAmount = 1;
        }    
        if(isCooldown) 
        {
            abilitiesImage1.fillAmount-=1/cooldown1*Time.deltaTime;
            if(abilitiesImage1.fillAmount<=0)
            {
                abilitiesImage1.fillAmount=0;
                isCooldown=false;
            }    
        }
    }
}
