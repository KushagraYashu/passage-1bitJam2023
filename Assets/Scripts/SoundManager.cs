using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource hit;
    public AudioSource levelPass;
    
    public void LevelPass()
    {
        levelPass.Play();
        
    }
    public void Hit()
    {
        hit.Play();
    }
}
