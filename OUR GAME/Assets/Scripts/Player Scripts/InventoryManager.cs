using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] public int slot;
    [SerializeField] public GameObject[] hotbar = new GameObject[3];
    public GameObject flashlight;
    public GameObject gun;
    public GameObject third;
    public bool hasGun;
    public GameObject overworldGun;
    public GameObject gunTrigger;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            overworldGun.SetActive(false);
            hasGun = true;
            hotbar[0].SetActive(false);
            hotbar[1].SetActive(hasGun);
            hotbar[2].SetActive(false);
            slot = 2;
            gunTrigger.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hasGun = false;
        hotbar[0] = flashlight;
        hotbar[1] = gun;
        hotbar[2] = third;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            hotbar[0].SetActive(true);
            hotbar[1].SetActive(false);
            hotbar[2].SetActive(false);
            slot = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            hotbar[0].SetActive(false);
            hotbar[1].SetActive(hasGun);
            hotbar[2].SetActive(false);
            slot = 2;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            hotbar[0].SetActive(false);
            hotbar[1].SetActive(false);
            hotbar[2].SetActive(hasGun);
            slot = 3;
        }
    }
}