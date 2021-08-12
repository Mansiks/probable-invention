
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject trigger;
    public GameObject E;
    void OnTriggerStay(Collider other)
    {
        E.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true); trigger.SetActive(false); E.SetActive(false);
        }
    }

    void OnTriggerExit(Collider Other)
    {
        E.SetActive(false);
    }
}