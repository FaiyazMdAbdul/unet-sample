using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float lookSpeed = 3;
    private Vector2 rotation = new Vector2(15,160);
    public Transform hacker;
    private void Start()
    {
        Camera.main.transform.LookAt(hacker);
    }
    public void LookX() // Look rotation (UP down is Camera) (Left right is Transform rotation)
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");

        rotation.x = Mathf.Clamp(rotation.x, -30f, 30f);
       // rotation.y = Mathf.Clamp(rotation.y, -60f, 60f);

        transform.eulerAngles = new Vector2(rotation.x, rotation.y) * lookSpeed;
        Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * lookSpeed, rotation.y, 0);
    }
  


private void Update()
    {
        LookX();
        
    }
}
