using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Button : MonoBehaviour
{
    public GameObject Dia_log;
    public GameObject Kit_log;
    public GameObject Kit_;

    public GameObject Question;
    public GameObject TrueDailog;
    public GameObject FalseDailog;
    public GameObject FightDailog;
    public GameObject ExitDailog;
    public GameObject PausePanel;

    public GameObject ResultCard;

    public GameObject SettingCard;
    public AudioMixer audioMixer;
    public GameObject joystick;
    public GameObject deviceChoose;
    public int Kit;
    public Text Kit_nub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//next button
    public void Next(){
        SoundManager.instance.ClickClip();
        Dia_log.SetActive(false);
    }
//ready button
    public void Ready(){
        SoundManager.instance.ClickClip();
        Kit_log.SetActive(false);
        Question.SetActive(true);
    }
//if the answer is right
    public void True(){
        SoundManager.instance.ClickClip();
        SoundManager.instance.CollectClip();
        Question.SetActive(false);
        Kit += 1;
        Kit_nub.text = Kit.ToString();
        Kit_.SetActive(false);
        TrueDailog.SetActive(true);
        
    }
    public void True_continue(){
        SoundManager.instance.ClickClip();
        TrueDailog.SetActive(false);
    }
//if the answer is wrong
    public void False(){
        SoundManager.instance.ClickClip();
        Question.SetActive(false);
        Kit_.SetActive(false);
        FalseDailog.SetActive(true);
    }
    public void False_continue(){
        SoundManager.instance.ClickClip();
        FalseDailog.SetActive(false);
    }

// defeat continue
    public void FightContinue(){
        SoundManager.instance.ClickClip();
        FightDailog.SetActive(false);
    }

// result card
    public void Result(){
        SoundManager.instance.ClickClip();
        ExitDailog.SetActive(false);
        ResultCard.SetActive(true);
        Time.timeScale = 0f;
    }

//pause
    public void Pause(){
        SoundManager.instance.ClickClip();
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
//continue the game
    public void Return(){
        SoundManager.instance.ClickClip();
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
//setting card open
    public void Setting(){
        SoundManager.instance.ClickClip();
        SettingCard.SetActive(true);
        Time.timeScale = 0f;
    }
//setting card close
    public void Close(){
        SoundManager.instance.ClickClip();
        SettingCard.SetActive(false);
        Time.timeScale = 1f;
    }

//volume change
    public void SetVolume(float value){
        audioMixer.SetFloat("MainVolume", value);
    }

    // if the user choose the mobile device it will enable the joystick, and when the user choose desktop it will disable the joystick.
    public void Mobile(){
        SoundManager.instance.ClickClip();
        joystick.SetActive(true);
        deviceChoose.SetActive(false);
        
    }

    public void Desktop(){
        SoundManager.instance.ClickClip();
        joystick.SetActive(false);
        deviceChoose.SetActive(false);
    }
}