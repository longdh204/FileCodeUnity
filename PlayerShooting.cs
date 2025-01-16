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

        // Xoay Hand theo vị trí của Sign (giữ nguyên như cũ)
        Vector3 relative = Hand.InverseTransformPoint(Sign.position);
        float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
        Hand.Rotate(0, 0, angle);
    }
}