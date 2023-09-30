using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missileMove : MonoBehaviour
{
    public GameObject missile;
    float time;
    public GameObject explosion;
    public GameObject enemy;
    public GameObject trail;
    bool collided = false;
    public Text myText;
    public Transform spawn;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(missile != null)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), 0.01f);
            if (time > 0.5f)
            {
               missile.GetComponent<Rigidbody>().AddForce(Vector3.back * 0.5f, ForceMode.Impulse);
            }
        }
        if (transform.position.z < -40 && missile != null)
        {
            Destroy(missile);
        }
        if (collided && enemy != null && missile != null)
        {
            Destroy(missile);
            collided = false;
        }
        if (GameObject.Find("PlasmaExplosionEffect(Clone)") != null)
        {
            Destroy(GameObject.Find("PlasmaExplosionEffect(Clone)"), 2);
        }


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy(Clone)")
        {

            score += 1;

            Destroy(collision.gameObject);
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            
            
            if (!collided)
            {
                Instantiate(explosion, position, rotation);
                collided = true;
            }
        }
    }
}
