using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Create a new asset menu for creating Gun scriptable objects
[CreateAssetMenu(fileName = "New Gun", menuName = "Scriptable Objects/Gun")]
public class Gun : ScriptableObject
{
    // Name of the gun
    public string gunName;

    // Damage of the gun
    public int damage;

    // Accuracy of the gun
    public int accuracy;

    // Range of the gun
    public int range;

    // Fire rate of the gun
    public int fireRate;

    // Model of the gun to be displayed in the game
    public GameObject gunModel;
}