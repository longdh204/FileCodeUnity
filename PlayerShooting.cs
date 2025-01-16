using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lớp PlayerMovement kế thừa từ MonoBehaviour
public class PlayerShooting : MonoBehaviour
{
    public Joystick joystick; // Khai bao de su dung JoystickJoystick
    public Rigidbody2D rb; // Khai bao de su dung Rigitbody2D 
    public Transform Sign;
    void Start(){

    }

    void FixedUpdate(){
        Vector2 Input = new Vector2(joystick.Horizontal, joystick.Vertical); // Nhận giá trị từ joystick
        rb.MovePosition((Vector2) Sign.position + Input * 10 * Time.deltaTime);

        if(Input.x > 0){
            transform.rotation = Quaternion.Euler(0,0,0);
            GetComponent<Animator>().SetInteger("Mode", 1);
        }
        else if(Input.x < 0){
            transform.rotation = Quaternion.Euler(0,180,0);
            GetComponent<Animator>().SetInteger("Mode", 1);
        }else{
            GetComponent<Animator>().SetInteger("Mode", 0);
        }
    }
}