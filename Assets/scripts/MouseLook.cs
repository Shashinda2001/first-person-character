using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivly = 100f;
    public Transform playerBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivly * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivly * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
