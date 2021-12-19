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
        UpgradeCurrency,
        UpgradePerClick
        //define item types here

    }

    public ItemType type;
    [SerializeField]
    Button UpgradeButton;
    TapManager tapManager;
    [SerializeField] Canvas UIupgradeTextCountSpawn;
    bool canUpgrade;
   [SerializeField] float increment;
    [SerializeField]
    TMP_Text buttonUpgradeText,buttonCostText;
    [SerializeField]
    float upgradeCost;
    public string ButtonInfo;


    // Start is called before the first frame update
    void Start()
    {
        canUpgrade = true;
        upgradeCost = 30;
        UpgradeButton.onClick.AddListener(OnItemUpdate);
        tapManager = (TapManager)FindObjectOfType(typeof(TapManager));

        //buttonUpgradeText.text = ButtonInfo + " + " + increment;
        //buttonCostText.text = upgradeCost.ToString();

    }

    void Test()
    {
    }



    void OnItemUpdate()
    {
        if(canUpgrade)
        {
            InvokeRepeating("GeneratePoint", 0f, 2f);
            UpgradeButton.onClick.RemoveAllListeners();
            UpgradeButton.onClick.AddListener(UpgradeOnly);
            upgradeCost += 250;
            canUpgrade = false;
        }
    }



    void OnSetUpgradeUI()
    {
        buttonUpgradeText.text = ButtonInfo + " + " + increment;
        buttonCostText.text = upgradeCost.ToString();
    }


    void UpgradeOnly()
    {
        increment += 2;
        upgradeCost += 250;
 
    }

    void GeneratePoint()
    {
        tapManager.TapCounter = tapManager.TapCounter += (int)increment;
     //   SpawnFoatingTextOnClick();

    }

    void SpawnFoatingTextOnClick()
    {
        var txt = Instantiate(UIupgradeTextCountSpawn, new Vector3(2, -1.24f, 0), Quaternion.identity);
        txt.transform.GetChild(0).GetComponent<TMP_Text>().text = "+" + increment;
    }

    // Update is called once per frame
    void Update()
    {
       // OnSetUpgradeUI();
    }
}
