using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    TMP_Text currentInGameCurrencyText;
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        TapManager._CurrencyText += UpdateCurrencyText;
    }

    private void UpdateCurrencyText(int currency)
    {
        currentInGameCurrencyText.text = currency.ToString();
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
