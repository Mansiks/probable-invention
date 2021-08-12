using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RainScript : MonoBehaviour
{
    System.Random rnd = new System.Random();
    public float timer;
    public ParticleSystem rainSource;
    public float nextRain;
    public float nextRainLength;
    public float nextRainEnd;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        nextRain = rnd.Next(300, 420);
        nextRainEnd = nextRain + 5;
        rainSource.maxParticles = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= nextRain)
        {
            nextRainEnd = timer + 5;
            rainSource.maxParticles += 3;
            if (rainSource.maxParticles >= 10000)
            {
                nextRainLength = rnd.Next(300, 420);
                nextRainEnd = timer + nextRainLength;
                nextRain = nextRainEnd + 5;
            }
        }
        else if (timer >= nextRainEnd)
        {
            nextRain = timer + 5;
            rainSource.maxParticles -= 3;
            if (rainSource.maxParticles == 0)
            {
                nextRain = timer + rnd.Next(300, 420);
                nextRainEnd = nextRain + 5;
            }
        }
    }
}
