using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class missileFire : MonoBehaviour
{
    public GameObject missile;
    public Transform spawn;
    public Transform ship;
    public GameObject trail;
    public Text myText;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && missile != null)
        {
            spawn.position = new Vector3(ship.position.x, ship.position.y, ship.position.z);   
            Instantiate(missile, new Vector3(spawn.position.x, spawn.position.y, spawn.position.z), Quaternion.identity);

            //if (GameObject.Find("RocketTrailEffect(Clone)") == null)
            //{
            //    Instantiate(trail, spawn);
            //}
        }
        myText.text = "Score: " + missileMove.score;

    }
}
