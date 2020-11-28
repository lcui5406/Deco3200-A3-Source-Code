using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
   
    public AudioSource audioSource;
    [SerializeField]
    private AudioClip hurtClip, collectClip, successClip, fightClip, clickClip;
    // Start is called before the first frame update
    private void Awake(){
        instance = this;
    }
    public void HurtClip(){
        audioSource.clip = hurtClip;
        audioSource.Play();
    }

    public void CollectClip(){
        audioSource.clip = collectClip;
        audioSource.Play();
    }
    public void SuccessClip(){
        audioSource.clip = successClip;
        audioSource.Play();
    }

    public void FightClip(){
        audioSource.clip = fightClip;
        audioSource.Play();
    }

    public void ClickClip(){
        audioSource.clip = clickClip;
        audioSource.Play();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}