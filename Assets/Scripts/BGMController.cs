using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{

    public AudioClip[] BGMArr;
    private AudioSource audioSource;
    int tabcount = 1;
    float vol = 1f;
    float volrate = 0.1f;

    bool Stop = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //play first BGM audio
        audioSource.PlayOneShot(BGMArr[0]); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //increase the number of tabcount when press tab key
            //every increase will change to a new music
            tabcount++;
            //int rand = Random.Range(0, BGMArr.Length);
            if (tabcount == 1)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(BGMArr[0]);
            }
            if (tabcount == 2)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(BGMArr[1]);
            }
            if (tabcount == 3)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(BGMArr[2]);
            }
            if(tabcount > 3)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(BGMArr[0]);
                tabcount = 1;
                
            }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vol = vol + (volrate * Time.deltaTime);
            audioSource.volume = vol;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vol = vol - (volrate * Time.deltaTime);
            audioSource.volume = vol;
        }

       
    }
}
