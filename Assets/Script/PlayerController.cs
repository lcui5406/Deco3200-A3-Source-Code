using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public float speed;
    public int Dia;

    public Text Dia_nub;
    public GameObject Dia_log;
    public GameObject fightDia;
    public Joystick joystick;
    // public GameObject joyStick;
    public Text KitNub;
    public int kitNub;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        DeviceMovement();
    }
        
    
    void DeviceMovement(){
        MobileMovement();
        DesktopMovement();
    }

    //player move mobile
    void MobileMovement(){
        float move_h = joystick.Horizontal;
        float move_v = joystick.Vertical;
        if (move_h != 0)
        {
            rb.velocity = new Vector2(move_h * speed, rb.velocity.y);
            anim.SetFloat("running", Mathf.Abs(move_h));
        }
        if (move_v != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, move_v * speed);
            anim.SetFloat("running", Mathf.Abs(move_v));
        }
    }
    //player move desktop
    void DesktopMovement(){
        float move_h;
        move_h = Input.GetAxis("Horizontal");
        float move_v;
        move_v = Input.GetAxis("Vertical");
       
        if (move_h != 0)
        {
            rb.velocity = new Vector2(move_h * speed, rb.velocity.y);
            anim.SetFloat("running", Mathf.Abs(move_h));
        }
        if (move_v != 0)
        {
            rb.velocity = new Vector2(rb.velocity.y, move_v * speed);
            anim.SetFloat("running", Mathf.Abs(move_v));
        }
    }
    //collect the item
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Collection")
        {
            Destroy(collision.gameObject);
            //update the number
            Dia += 1;
            Dia_nub.text = Dia.ToString();
            //collection completed dialog
            Dia_log.SetActive(true);
            SoundManager.instance.CollectClip();

            // Dia_log.SetActive(false);
        }
    }
    
    // private void OnTriggerEnter2D(Collider2D collision){
    //     if (collision.tag == "Kit")
    //     {
    //         Destroy(collision.gameObject);
    //         //update the number
    //         Kit += 1;
    //         Kit_nub.text = Dia.ToString();
    //         // Dia_log.SetActive(false);
    //     }
    // }


    //meet the virus
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Virus")
        {
            kitNub = int.Parse(KitNub.text);
            if ( kitNub == 0){
                SoundManager.instance.HurtClip();
                PlayerDead();
            }
            else{
                SoundManager.instance.FightClip();
                fightDia.SetActive(true);
                Destroy(collision.gameObject);
                kitNub -= 1;
                KitNub.text = kitNub.ToString();
            }
            
        }
        
    }
    //player dead
    public void PlayerDead(){
        GameManager.GameOver(true);
    }

    // public bool Device(){
    //     Menu.instance.DeviceChoose();
    // }
}