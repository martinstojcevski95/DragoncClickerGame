using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;

    public static GameManager Instance { get { return _Instance; } }



    public UnityEvent OnTapToEarnGold;

    [SerializeField] private float playerGold;


    private void Awake()
    {
        if (_Instance != null && _Instance != this)
            Destroy(this.gameObject);
        else
            _Instance = this;
    }

    public void TapToEarnGoldEvent()
    {
        OnTapToEarnGold?.Invoke();
    }


    public float PlayerGold
    {
        get { return playerGold; }
        set { playerGold = value; }
    }
}
