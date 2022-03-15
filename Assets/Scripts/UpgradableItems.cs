using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradableItems : MonoBehaviour
{

    public enum UpgradeType
    {
        GoldPerTap,
        PassiveIncome,
        Multiplier
    }

    public UpgradeType upgradeType;
    public float upgradeIncrementValue;
    public float upgradeCost;
    float currentPlayerGoldHolder;

    public static event Action _UpgradeBuyed;

  //  public List<UpgradableItem> UpgradableItemss = new List<UpgradableItem>();



    public void Start()
    {
        // var findUpgradeItems = FindObjectsOfType<UpgradableItem>();
        //foreach (var item in findUpgradeItems)
        //{
        //    UpgradableItemss.Add(item);
        //}
    }



    //private void Start()
    //{
    //    this.GetComponent<Button>().onClick.AddListener(OnSetUpgrade);
    //}


    //public void OnUpgradeBuyedEvent()
    //{
    //    _UpgradeBuyed?.Invoke();
    //}

    //public void OnSetUpgrade()
    //{
    //    currentPlayerGoldHolder = MainManager.Instance.CurrentPlayerGold();
    //    switch (upgradeType)
    //    {
    //        case UpgradeType.GoldPerTap:
    //            GPSUpgrade();
    //            break;

    //        case UpgradeType.Multiplier:
    //            MultiplierIncrement();
    //            break;

    //        case UpgradeType.PassiveIncome:
    //            PassiveIncomeUpgrade();
    //            break;
    //    }
    //}

    //public void GPSUpgrade()
    //{
    //    if (currentPlayerGoldHolder >= upgradeCost)
    //    {
    //        MainManager.Instance.RemoveGoldOnBuy(upgradeCost);
    //        UpgradePrice(2.5f);
    //        MainManager.Instance.GoldPerTapValue += upgradeIncrementValue;
    //    }
    //}


    //public void PassiveIncomeUpgrade()
    //{
    //    if (currentPlayerGoldHolder >= upgradeCost)
    //    {
    //        MainManager.Instance.RemoveGoldOnBuy(upgradeCost);
    //        UpgradePrice(1.5f);
    //        MainManager.Instance.PassiveIncomeValue += upgradeIncrementValue;
    //    }
    //}

    //public void MultiplierIncrement()
    //{
    //    if (currentPlayerGoldHolder >= upgradeCost)
    //    {
    //        MainManager.Instance.RemoveGoldOnBuy(upgradeCost);
    //        UpgradePrice(1.5f);
    //        MainManager.Instance.MultiplierValue += upgradeIncrementValue;
    //    }
    //}



    //void UpgradePrice(float priceMultiplier)
    //{
    //   upgradeCost  = Mathf.Round(upgradeCost * priceMultiplier);
    //}
}
