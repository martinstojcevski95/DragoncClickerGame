using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static InfernoStudios.IncrementalsManager;

public class UpgradableItem : MonoBehaviour
{


    [SerializeField] private float upgradeIncrementValue;
    [SerializeField] private float upgradeCost;
    [SerializeField] UpgradeType itemUpgradeType;
    [SerializeField] TMP_Text upgradeCostTxt, UpgradeIncrementTxt;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(UpgradeItem);
        UpgradeIncrementTxt.text = string.Format(" Upgrade Increment {0}", upgradeIncrementValue);
        upgradeCostTxt.text = string.Format("Cost Value {0}", upgradeCost);
    }

    public void UpgradeItem()
    {
        IncrementalsInstance.onUpgradeComplete.AddListener(OnUpgradeComplete);
        IncrementalsInstance.Upgrade(itemUpgradeType, upgradeIncrementValue);
    }

    private void OnUpgradeComplete(bool status)
    {
        if (status)      
            IncrementUpdateValueAndCost();
    }

    void IncrementUpdateValueAndCost()
    {
        upgradeIncrementValue += 50;
        upgradeCost += 25;

        UpgradeIncrementTxt.text = string.Format(" Upgrade Increment {0}", upgradeIncrementValue);
        upgradeCostTxt.text = string.Format("Cost Value {0}", upgradeCost);
    }
}
