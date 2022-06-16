using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float rotationDSpeed;
    public float rotationASpeed;
    public float movementWSpeed;
    public float movementSSpeed;
    //private float originalscale = 3;

    float tiempo = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tiempo + 6)
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
            if (transform.localScale.y >= 0.8 && transform.localScale.y <= 7)
            {
                if (transform.localScale.x >= 1 && transform.localScale.x <= 6)
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        transform.localScale += new Vector3(-0.1f, 0.1f, 0);
                    }

                }
            }


            if (transform.localScale.y >= 1 && transform.localScale.y <= 7)
            {
                if (transform.localScale.x >= 0.8 && transform.localScale.x <= 6)
                {
                    if (Input.GetKey(KeyCode.Q))
                    {
                        transform.localScale += new Vector3(0.1f, -0.1f, 0);
                    }

                }
            }

            if (transform.position.y <= -1)
            {
                SceneManager.LoadScene("Perdiste"); ;
            }
        }
    }
}
