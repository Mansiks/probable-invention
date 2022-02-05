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
    public bool isRaining;
    public float particles;

    const int MAX_PARTICLES = 10000;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        nextRain = 0;//rnd.Next(300, 420);
        nextRainEnd = nextRain + 5;
        rainSource.maxParticles = 0;
        isRaining = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= nextRain)
        {
            isRaining = true;
            nextRainEnd = timer + 5;
            particles += MAX_PARTICLES / 20 * Time.deltaTime;
            rainSource.maxParticles = (int) particles;
            if (rainSource.maxParticles >= MAX_PARTICLES)
            {
                nextRainLength = rnd.Next(300, 420);
                nextRainEnd = timer + nextRainLength;
                nextRain = nextRainEnd + 5;
            }
        }
        else if (timer >= nextRainEnd)
        {
            isRaining = false;
            nextRain = timer + 5;
            particles -= MAX_PARTICLES / 20 * Time.deltaTime;
            rainSource.maxParticles = (int) particles;
            if (rainSource.maxParticles <= 0)
            {
                nextRain = timer + rnd.Next(300, 420);
                nextRainEnd = nextRain + 5;
            }
        }
    }
}
