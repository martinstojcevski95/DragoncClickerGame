using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{


    [SerializeField] private TMP_Text PlayerGoldText;



    public void SetPlayerGoldUI()
    {
        PlayerGoldText.text = FormatNumber((int)GameManager.Instance.PlayerGold);
    }


    string FormatNumber(int num)
    {

        if (num >= 1000)
            return FormatNumber(num / 1000) + "K";
            
        if (num >= 100000)
            return FormatNumber(num / 1000) + "K";

        if (num >= 10000)
            return (num / 1000D).ToString("0.#") + "K";

        return num.ToString("#,0");
    }
}
