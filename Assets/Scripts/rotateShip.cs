using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateShip : MonoBehaviour
{
    float a = 0.45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates 45 degrees each second
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.z < 0.45)
            {
                transform.Rotate(0, 0, a);
            }
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.z > -0.45)
            {
                transform.Rotate(0, 0, -a);
            }
        }
        else
        {
            if (transform.rotation.z > 0)
            {
                transform.Rotate(0, 0, -a);
            }
            else if (transform.rotation.z < 0)
            {
                transform.Rotate(0, 0, a);
            }
        }
    }
}
