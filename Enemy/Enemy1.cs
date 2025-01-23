using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb; // Sử dụng vật lý thì phải sử dụng cái này
    public GameObject Player; // khai báo player để cái súng quay theo player
    public Transform GunPivot; // Khai báo cái súng để kéo cái súng quay theo player
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // đoạn code này để cái súng xoay theo player như cái súng của người chơi í
        Vector3 relative = GunPivot.InverseTransformPoint(Player.transform.position);
        float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
        GunPivot.Rotate(0, 0, angle);
        // Nếu kẻ địch ở phía bên phải của người chơi, lật trục xoay của súng để hướng về người chơi.
        if (this.transform.position.x - Player.transform.position.x > 0)
        {
            GunPivot.rotation = Quaternion.Euler(0, 180, GunPivot.transform.eulerAngles.z); // Lật súng
        }
        else
        {
            // Nếu kẻ địch ở bên trái người chơi, không lật súng.
            GunPivot.rotation = Quaternion.Euler(0, 0, GunPivot.transform.eulerAngles.z);
        }
    }
}
