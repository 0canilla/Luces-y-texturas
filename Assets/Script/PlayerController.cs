using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float Speed = 1.20f;
    float cameraX;
    float cameraY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        Rotate();
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(Speed * Time.deltaTime * direction);
    }

    private void Rotate()
    {
        cameraX += Input.GetAxis("Mouse X");
        cameraY += Input.GetAxis("Mouse Y");
        Quaternion Angulo = Quaternion.Euler(-cameraY, cameraX, 0);
        transform.localRotation = Angulo;
    }
}
