using System.Collections;
using System.Collections.Generic;
using GameDevTV.Inventories;
using RPG.Inventories;
using UnityEngine;

public class ChestPickupManager : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] Pickup pickup;
    [SerializeField] OtherInventorySpawner otherInventorySpawner;
    [SerializeField] OtherInventory otherInventory;

    [SerializeField] public bool isLooted = false;


    private void OnEnable()
    {
        isLooted = false;
        //inventory.inventorySize = otherInventorySpawner.numberOfSlotsToSpawn;
    }
    private void Update()
    {
        if (inventory.FreeSlots() == inventory.slots.Length && isLooted == true)
        {
            pickup.PickupRespawnCoroutine();
            otherInventorySpawner.numberOfSlotsToSpawn = 0;
        }
    }

}
