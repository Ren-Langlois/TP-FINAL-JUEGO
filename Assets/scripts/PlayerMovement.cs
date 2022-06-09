using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationDSpeed;
    public float rotationASpeed;
    public float movementWSpeed;
    public float movementSSpeed;
    private float originalscale = 3;
    private float maxscale = 7;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementWSpeed);
            // transform.localScale = new Vector3(originalscale, originalscale, originalscale);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSSpeed);
            //transform.localScale = new Vector3(originalscale, originalscale, originalscale);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationDSpeed, 0);
            //transform.localScale = new Vector3(originalscale, originalscale, originalscale);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationASpeed, 0);
            //transform.localScale = new Vector3(originalscale, originalscale, originalscale);
        }

        //controles especiales
        if (Input.GetKey(KeyCode.E))
        {
            transform.localScale += new Vector3(-0.1f, 0.1f, -0.1f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localScale += new Vector3(0.1f, -0.1f, -0.1f);
        }
        //if (maxscale > 7)
        //{

        //}

    }
}
