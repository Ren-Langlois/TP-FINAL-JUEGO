using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParedesMovement : MonoBehaviour
{
    public float WallSpeed = 0.1f;
    public int pose = -30;
    float tiempo = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tiempo +6)
        {


            transform.position -= new Vector3(0, 0, WallSpeed);

            while (transform.position.z < pose)
            {
                transform.position += new Vector3(0, 0, 300);
                WallSpeed += 0.1f;
                
            }
        }
    }
  
    
}
