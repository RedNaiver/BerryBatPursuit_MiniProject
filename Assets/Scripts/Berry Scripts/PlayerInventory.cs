using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBerries { get; private set;}
    public UnityEvent<PlayerInventory> OnBerryCollected;
    public UnityEvent OnAllBerriesCollected; // New event for all berries collected


    public void BerryCollected()
    {
        NumberOfBerries++;
        OnBerryCollected.Invoke(this);
        
        // Check if all berries are collected
        if (NumberOfBerries >= 10)
        {
            // Trigger the "all berries collected" event
            OnAllBerriesCollected.Invoke(); 
        }
    }
}
