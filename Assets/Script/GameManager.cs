using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    static GameManager instance;
    public GameObject gameOverUI;
    public GameObject alertDailog;
    public int device;

    // public Text KitNub;
    private void Awake(){
        if (instance != null){
            Destroy(gameObject);
        }
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //restart the game
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    //quit the game 
    public void Quit(){
        Application.Quit();
    }

    // Player dead
    public static void GameOver(bool dead){
        if (dead){
            instance.alertDailog.SetActive(false);
            instance.gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

//if the device is mobile the return is 0; if the device is desktop the return is 1;

}