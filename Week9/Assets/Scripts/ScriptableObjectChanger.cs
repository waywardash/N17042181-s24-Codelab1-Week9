using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] scriptableObjects; // Array of ScriptableObjects representing different guns

    [Header ("Display Scripts")]
    [SerializeField] private GunDisplay gunDisplay; // Reference to the GunDisplay script
    private int currentMapIndex; // Index to keep track of the current ScriptableObject being displayed

    private void Awake()
    {
        // When the script starts, display the first ScriptableObject
        ChangeMap(0);
    }

    // Method to change the displayed ScriptableObject
    public void ChangeMap(int _index)
    {
        currentMapIndex += _index; // Increment or decrement the current index based on the parameter

        // Wrap around to the last index if the index goes below 0
        if (currentMapIndex < 0) 
            currentMapIndex = scriptableObjects.Length - 1;

        // Wrap around to the first index if the index exceeds the length of the array
        if (currentMapIndex > scriptableObjects.Length - 1) 
            currentMapIndex = 0;
        
        // If a GunDisplay script is attached, update the displayed gun
        if(gunDisplay != null) 
            gunDisplay.UpdateGun((Gun)scriptableObjects[currentMapIndex]);
    }
}