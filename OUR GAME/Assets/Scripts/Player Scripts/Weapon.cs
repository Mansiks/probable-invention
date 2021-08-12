using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bullet;
    public int bulletForce = 5000;
    public int magaz = 30;
    public AudioClip fire;
    public AudioClip reload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & magaz > 0)
        {
            Transform bulletInstance = (Transform)Instantiate(bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            magaz -= 1;
            GetComponent<AudioSource>().PlayOneShot(fire);
            GetComponent<AudioSource>().PlayOneShot(reload);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            magaz = 30;
        }
    }
}

