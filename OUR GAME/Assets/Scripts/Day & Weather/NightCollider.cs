using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightCollider : MonoBehaviour
{
    public BoxCollider Night;
    public BoxCollider Evening;
    public NightChanger nightchanger;
    

    // Start is called before the first frame update
    void Start()
    {
        Night.enabled = false;
        Evening.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nightchanger.isNight == true)
        {
            Night.enabled = true;
        }
        else Night.enabled = false;
        if (nightchanger.isEvening == true) Evening.enabled = true;
        else Evening.enabled = false;
        
    }
}
