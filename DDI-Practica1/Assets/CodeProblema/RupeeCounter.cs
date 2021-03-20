using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RupeeCounter : MonoBehaviour
{
    public AudioClip rupeeSound;
    public new AudioSource audio;
    public int RupeeCount = 0;
    public Text RupeeText;
    public int maxRupee = 999;
    
    public void UpdateCount(int RupeeValue)
    {
        audio = GetComponent<AudioSource>();
        audio.clip = rupeeSound;
        audio.Play();

        if(RupeeCount <= maxRupee)
            RupeeCount += RupeeValue;
        
        RupeeText.text = RupeeCount.ToString();
    }
}
