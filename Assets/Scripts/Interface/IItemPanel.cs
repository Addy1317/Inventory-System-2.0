using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemPanel 
{
    public void AddItemToPanel(ItemScriptableObject itemData, int quantity);
    public void RemoveItemFromPanel(ItemScriptableObject itemData);
    public void UpdateItemInPanel(ItemScriptableObject itemData, int quantity);
    public bool HasItemControllerKey(ItemScriptableObject itemData);
}
