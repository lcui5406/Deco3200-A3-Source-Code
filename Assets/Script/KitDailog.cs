using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitDailog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Kit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//if meet the kit 
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            Kit.SetActive(true);
        }
    }
}