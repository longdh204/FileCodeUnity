using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lớp PlayerMovement kế thừa từ MonoBehaviour
public class PlayerShooting1 : MonoBehaviour
{
    public Joystick joystick; // Khai bao de su dung JoystickJoystick
    public Rigidbody2D rb; // Khai bao de su dung Rigitbody2D 
    public Transform Sign; // Diem ngam
    public GameObject Bullet; // Vien dan
    public Transform Tip; // Điểm bắn 
    public Manager1 Manager1;
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
    public void StartShotting()
    {
        if(Manager1.LeftJoy == 0)
            GetComponent<Animator>().SetInteger("Mode", 2);
        if (Manager1.RightJoy == 1)
            GetComponent<Animator>().SetInteger("Mode", 3);
    }

    public void EndShotting()
    {
        if (Manager1.LeftJoy == 0)
            GetComponent<Animator>().SetInteger("Mode", 0);
        if (Manager1.RightJoy == 1)
            GetComponent<Animator>().SetInteger("Mode", 1);
    }
    public void Shooting()
    {
        GameObject bullet = Instantiate(Bullet, Tip.position, Quaternion.identity);
        Vector2 direction = (Sign.position - Tip.position).normalized;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * 30;
    }
}