using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesMovement : MonoBehaviour
{
    public float WallSpeed;
    public int pose = -30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, WallSpeed);

        while (transform.position.z < pose)
        {
            transform.position += new Vector3(-3, 3, 150);
        }
    }
  
    
}
