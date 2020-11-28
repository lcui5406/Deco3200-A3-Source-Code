using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertDailog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Alert;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
// when the player is around the virus monster
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            Alert.SetActive(true);
        }
    }
// when the player left the virus monster
    private void OnTriggerExit2D(Collider2D collision){
        if (collision.tag == "Player"){
            Alert.SetActive(false);
        }
    }
}