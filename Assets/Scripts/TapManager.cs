using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TapManager : MonoBehaviour
{

    int tapCounter;
    float tapCounterIncrementValue;



    [SerializeField] Canvas tappedText;

    [SerializeField] Button buttonForTapping;

    public static event Action<int> _CurrencyText;

    MainManager mainManager;

    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 120;
        mainManager = (MainManager)FindObjectOfType(typeof(MainManager));
    }

    private void OnEnable()
    {
        MainManager._TapGoldIncrement += OnButtonTap;
    }

    public void OnCurrencyEarnedEvent()
    {
      //  _CurrencyText?.Invoke(TapCounter);
    }

    public void OnButtonTap()
    {
        buttonForTapping.transform.DOShakePosition(0.2f, 2, 4, 80f, false);

       // TapCounter++;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(worldPosition);
        var txt = Instantiate(tappedText, new Vector3(worldPosition.x - 1.8f, worldPosition.y, 0), Quaternion.identity);

        txt.transform.DOJump(new Vector3(worldPosition.x - 2f, worldPosition.y + 0.5f, 0), 0.8f, 1, 0.6f, false);
        txt.transform.GetChild(0).GetComponent<TMP_Text>().text = "+1";
        var sprite = txt.transform.GetChild(1).GetComponent<Image>();
        sprite.DOFade(0, 0.6f);
        if (mainManager != null)
        {
            mainManager.Gold += 1;
        }

    }


    //public int TapCounter
    //{
    //    get
    //    {
    //        return tapCounter;
    //    }
    //    set
    //    {
    //        tapCounter = value;

    //        OnCurrencyEarnedEvent();
    //    }
    //}

    //public float TapCaunterIncrementValue
    //{
    //    get
    //    {
    //        return tapCounterIncrementValue;
    //    }
    //    set
    //    {
    //        tapCounterIncrementValue = value;
    //    }

    //}
    

   
}
