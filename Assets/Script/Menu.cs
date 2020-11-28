using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static Menu instance;
    // public int device;
    // public GameObject joystick;
    private void Awake(){
        instance = this;
    }

    //Go into the next scene
    public void PlayGame(){
        SoundManager.instance.ClickClip();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    // Quit the game 
    public void Quit(){
        SoundManager.instance.ClickClip();
        Application.Quit();
    }



    // public bool DeviceChoose(){
    //     if (device == 0 ){
    //         return true;
    //     }else{
    //         return false;
    //     }
    // }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}