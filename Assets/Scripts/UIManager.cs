using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    TMP_Text currentGoldText;


    // Start is called before the first frame update
    void Start()
    {
        MainManager._TapGoldIncrement += UpgradeGoldText;
    }

    private void UpgradeGoldText()
    {
        currentGoldText.text = MainManager.Instance.Gold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
