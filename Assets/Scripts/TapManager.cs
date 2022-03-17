using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static InfernoStudios.IncrementalsManager;

public class TapManager : MonoBehaviour
{

    [SerializeField] Canvas tappedText;
    [SerializeField] Button buttonForTapping;

    // Start is called before the first frame update
    void OnEnable()
    {
        //GameManager.OnGoldIncrement += OnButtonTapEffect;
    }



    public void OnButtonTapEffect()
    {

        buttonForTapping.transform.DOShakePosition(0.2f, 2, 4, 80f, false);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var txt = Instantiate(tappedText, new Vector3(worldPosition.x - 1.8f, worldPosition.y, 0), Quaternion.identity);
        txt.transform.DOJump(new Vector3(worldPosition.x - 2f, worldPosition.y + 0.5f, 0), 0.8f, 1, 0.6f, false);
        txt.transform.GetChild(0).GetComponent<TMP_Text>().text = IncrementalsInstance.GoldPerTap.ToString("F0") ;
        var sprite = txt.transform.GetChild(1).GetComponent<Image>();
        sprite.DOFade(0, 0.6f);
    }
   
}


