using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    private AudioSource[] mysounds;
    private AudioSource die;
    private void Start()
    {
        mysounds= GetComponentsInChildren<AudioSource>();
        die = mysounds[0];
    }
    public void Playdie()
    {
        die.Play();
    }
}
