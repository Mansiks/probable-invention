using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelManager : MonoBehaviour
{
    public GameObject water;
    public RainScript rainScript;
    public BoxCollider lowLevel;
    public BoxCollider highLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rainScript.isRaining && water.transform.position.y <= 10)
        {
            water.transform.position += new Vector3(0, 0.06f * Time.deltaTime);
            if (water.transform.position.y >= 6)
            {
                lowLevel.enabled = false;
                highLevel.enabled = true;
            }
        }
        if (!rainScript.isRaining && water.transform.position.y >= 3)
        {
            highLevel.enabled = false;
            lowLevel.enabled = true;
            water.transform.position += new Vector3(0, -0.06f * Time.deltaTime);
        }
    }
}
