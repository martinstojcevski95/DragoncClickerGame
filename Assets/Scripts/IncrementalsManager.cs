using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IncrementalsManager : MonoBehaviour
{

    private static IncrementalsManager _Instance;

    public static IncrementalsManager Instance { get { return _Instance; } }

    private float goldPerTap = 2;
    private float goldMultiplier = 2;
    private float passiveIncome = 1;



    private void Awake()
    {
        if (_Instance != null && _Instance != this)
            Destroy(this.gameObject);
        else
            _Instance = this;
    }

    public void EarnGoldPerTap()
    {
        GameManager.Instance.PlayerGold += GoldPerTap;
    }

    public float GoldPerTap
    {
        get { return goldPerTap; }
        set { goldPerTap = value; }
    }

    public float GoldMultiplier
    {
        get { return goldMultiplier; }
        set { goldMultiplier = value; }
    }

    public float PassiveIncome
    {
        get { return passiveIncome; }
        set { passiveIncome = value; }
    }

}
