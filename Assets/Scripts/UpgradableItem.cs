using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradableItem : MonoBehaviour
{

   public enum ItemType
    { 
        GoldPerTap,
        PassiveIncome,
        Multiplier
    }



    //Item Type for each upgradable item
    public ItemType type;
    Button UpgradeButton;
    [SerializeField]
    float incrementValue;
    bool canUpgrade;


    // Start is called before the first frame update
    private void Start()
    {
        InitializeButton();   
    }

    private void OnEnable()
    {
        
    }

   
    private void OnDisable()
    {
        
    }

    void InitializeButton()
    {
        UpgradeButton = GetComponent<Button>();
        if (UpgradeButton == null) return;
        UpgradeButton.onClick.AddListener(MainUpgrade);
        canUpgrade = false;
    }



    /// <summary>
    /// Using to upgrade each button
    /// </summary>
    void MainUpgrade()
    {
        switch(type)
        {
            case ItemType.GoldPerTap:
                SetGPSUpgrade();
                break;

            case ItemType.Multiplier:
                SetMultiplier();
                break;

            case ItemType.PassiveIncome:
                SetPassiveIncome();
                break;
        }
    }


    #region Upgrades

    void SetGPSUpgrade()
    {
    }

    void SetMultiplier()
    {
     
    }

    void SetPassiveIncome()
    {
     
    }




    #endregion






}
