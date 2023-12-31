﻿using System.Collections;
using System.Collections.Generic;
using GameDevTV.Inventories;
using GameDevTV.UI.Inventories;
using RPG.Abilities;
using UnityEngine;
using UnityEngine.UI;
public class CraftingSlotUI: MonoBehaviour, IItemHolder
{
    [SerializeField] InventoryItemIcon icon = null;

    InventoryItem item;

    public void Setup(InventoryItem item, int number)
    {
        // Store the item parameter value in the local item variable.
        this.item = item;

        // Set both the item image and the amount number on the UI.
        icon.SetItem(item, number);
    }

    public InventoryItem GetItem()
    {
        // Return the set value in the item variable for the tooltip system
        return item;
    }
    
    public Ability GetAbility()
    {
        return null;
    }

}