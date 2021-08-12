using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    [SerializeField] public GameObject bot;
    [SerializeField] public int playerX;
    [SerializeField] public int playerZ;
    [SerializeField] public int botX;
    [SerializeField] public int botZ;
    [SerializeField] public string role;
    [SerializeField] public bool canKill;

    // Start is called before the first frame update
    void Start()
    {
        System.Random gen = new System.Random();
        int randomNumber = gen.Next(100);
        if (randomNumber <= 100) role = "seeker";
        else role = "hider";
    }

    // Update is called once per frame
    void Update()
    {
        playerX = (int) transform.position[0];
        playerZ = (int) transform.position[2];
        if (bot != null)
        {
            botX = (int) bot.transform.position[0];
            botZ = (int) bot.transform.position[2];
        }
        if (Math.Sqrt(Math.Abs(playerX - botX) * Math.Abs(playerX - botX) + Math.Abs(playerZ - botZ) * Math.Abs(playerZ - botZ)) < 4 && role == "seeker") canKill = true;
        else canKill = false;
        if (Input.GetKey("mouse 0") && canKill)
        {
            Destroy(bot);

        }
    }
}