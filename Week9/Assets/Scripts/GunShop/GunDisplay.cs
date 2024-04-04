using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunDisplay : MonoBehaviour
{
    [Header("Description")] 
    [SerializeField] private Text gunName; // Text field to display gun name

    [Header("Stats")] 
    [SerializeField] private Transform damageStars; 
    [SerializeField] private Transform accuracyStars; 
    [SerializeField] private Transform rangeStars; 
    [SerializeField] private Transform fireRateStars; 

    [Header("Gun Model")] 
    [SerializeField] private GameObject gunModel; // GameObject for displaying gun model

    
    public void UpdateGun(Gun _newGun)
    {
        // Update the displayed gun name
        gunName.text = _newGun.gunName;

        // Display damage stars based on the gun's damage stat
        for (int i = 0; i < damageStars.childCount; i++)
            damageStars.GetChild(i).gameObject.SetActive(i < _newGun.damage);

        // Display accuracy stars based on the gun's accuracy stat
        for (int i = 0; i < accuracyStars.childCount; i++)
            accuracyStars.GetChild(i).gameObject.SetActive(i < _newGun.accuracy);

        // Display range stars based on the gun's range stat
        for (int i = 0; i < rangeStars.childCount; i++)
            rangeStars.GetChild(i).gameObject.SetActive(i < _newGun.range);

        // Display fire rate stars based on the gun's fire rate stat
        for (int i = 0; i < fireRateStars.childCount; i++)
            fireRateStars.GetChild(i).gameObject.SetActive(i < _newGun.fireRate);

        // Destroy any existing gun model and instantiate the new gun model
        if (gunModel.transform.childCount > 0)
            Destroy(gunModel.transform.GetChild(0).gameObject);
        Instantiate(_newGun.gunModel, gunModel.transform.position, gunModel.transform.rotation, gunModel.transform);
    }
}
