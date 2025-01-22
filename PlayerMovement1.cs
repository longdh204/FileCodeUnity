using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lớp PlayerMovement kế thừa từ MonoBehaviour
public class PlayerMovement1 : MonoBehaviour
{
    public Joystick joystick; // Khai bao de su dung JoystickJoystick
    public Rigidbody2D rb; // Khai bao de su dung Rigitbody2D 
    public Manager1 Manager1;

    void Start(){

    }

    void FixedUpdate(){
        Vector2 Input = new Vector2(joystick.Horizontal, 0); // Nhận giá trị từ joystick
        rb.velocity = new Vector2(joystick.Horizontal * 500 * Time.deltaTime, this.rb.velocity.y);
        if(Input.x > 0){
            transform.rotation = Quaternion.Euler(0, 0, 0); // Quay đối tượng về phía phải
            if (Manager1.RightJoy == 0)
                GetComponent<Animator>().SetInteger("Mode", 1); // Đặt chế độ hoạt ảnh thành 1 (di chuyển)
            if (Manager1.RightJoy == 1)
                GetComponent<Animator>().SetInteger("Mode", 2); // Đặt chế độ hoạt ảnh thành 1 (di chuyển)
        }
        else if(Input.x < 0){
            transform.rotation = Quaternion.Euler(0, 180, 0); // Quay đối tượng về phía trái
            if (Manager1.RightJoy == 0)
                GetComponent<Animator>().SetInteger("Mode", 1); // Đặt chế độ hoạt ảnh thành 1 (di chuyển)
            if (Manager1.RightJoy == 1)
                GetComponent<Animator>().SetInteger("Mode", 2); // Đặt chế độ hoạt ả
        }
        else{
            GetComponent<Animator>().SetInteger("Mode", 0);
        }
    }
        public void Jump(){
        rb.velocity = new Vector2(0,60);
    }
}