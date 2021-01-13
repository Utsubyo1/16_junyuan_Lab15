using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Jumptext;
    public AudioClip[] AudioClipArr;
    private AudioSource audioSource;
    
    private int JumpCounter;
    private Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpCounter++;
            Jumptext.GetComponent<Text>().text = "Jump: " + JumpCounter;
            PlayerRb.AddForce(new Vector3(0, 250, 0));

            //audioSource.Play();
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
        
    }
}

