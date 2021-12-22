using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    float currentGold;



    public static event Action _TapGoldIncrement;

    public static MainManager Instance;




    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
            DestroyImmediate(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTapGoldIncrementEvent()
    {
        _TapGoldIncrement?.Invoke();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public float Gold
    {
        get
        {
            return currentGold;
        }
        set
        {
            currentGold = value;
        }
    }
}
