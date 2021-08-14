using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] public List<string> inventory = new List<string>();
    public int a;
    [SerializeField] public int slot;
    [SerializeField] public GameObject item1;
    [SerializeField] public GameObject item2;
    [SerializeField] public GameObject item3;
    public bool hasGun;
    public GameObject overworldGun;
    public GameObject gunTrigger;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            overworldGun.SetActive(false);
            hasGun = true;
            item1.SetActive(false);
            item2.SetActive(true);
            item3.SetActive(false);
            slot = 2;
            gunTrigger.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hasGun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            item1.SetActive(true);
            item2.SetActive(false);
            item3.SetActive(false);
            slot = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            item1.SetActive(false);
            item2.SetActive(hasGun);
            item3.SetActive(false);
            slot = 2;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(true);
            slot = 3;
        }
    }

    void addItem(string itemName)
    {
        inventory.Add(itemName);
    }

    void useItem(string itemName)
    {
        inventory.Remove(itemName);
    }

    int checkItemsCount(string itemName)
    {
        return inventory.Count;
    }
}