using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager1 : MonoBehaviour
{
    public int LeftJoy; // Joystick trai
    public int RightJoy; // Joystick phai
    public void Down_LeftJoy()
    {
        LeftJoy = 1;
    }
    public void Up_LeftJoy()
    {
        LeftJoy = 0;
    }
    public void Down_Right()
    {
        RightJoy = 1;
    }
    public void Up_RightJoy()
    {
        RightJoy = 0;
    }
}
