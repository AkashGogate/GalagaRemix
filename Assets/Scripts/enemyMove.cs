using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy!= null)
        {
            if (transform.position.z < -1 && transform.position.x < 16 && transform.position.z > -8)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z + 1), 0.02f);
                
                if (transform.rotation.z > -0.4f)
                {
                    transform.Rotate(0, 0, -0.4f);
                }
            }
            else if (transform.position.z < 6 && transform.position.x > -16 && transform.position.z > -1)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x-1, transform.position.y, transform.position.z + 1), 0.02f);
                if (transform.rotation.z < 0.4f)
                {
                    transform.Rotate(0, 0, 0.4f);
                }
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), 0.02f);
                if (transform.rotation.z > 0)
                {
                    transform.Rotate(0, 0, -0.4f);
                }
                if (transform.rotation.z < 0)
                {
                    transform.Rotate(0, 0, 0.4f);
                }
            }
        }
       
        if (transform.position.z > 8)
        {
           
            Destroy(enemy);
        }
        


    }

}
