using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class PowerRanking : MonoBehaviour
{
    [SerializeField] public GameObject coin;
    [SerializeField] public int playerX;
    [SerializeField] public int playerZ;
    [SerializeField] public int coinX;
    [SerializeField] public int coinZ;
    [SerializeField] public string role;
    [SerializeField] public bool coindistance;
    [SerializeField] public GameObject RankDesk;
    [SerializeField] public GameObject Text;
    [SerializeField] public int i;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        playerX = (int)transform.position[0];
        playerZ = (int)transform.position[2];
        if (coin != null)
        {
            coinX = (int)coin.transform.position[0];
            coinZ = (int)coin.transform.position[2];
        }
        if (Math.Sqrt(Math.Abs(playerX - coinX) * Math.Abs(playerX - coinX) + Math.Abs(playerZ - coinZ) * Math.Abs(playerZ - coinZ)) < 4 ) coindistance = true;
        else coindistance = false;
        if (Input.GetKey("mouse 0") && coindistance && coindistance != null)
        {
            Destroy(coin);

            
            
        }
       
    }
}
