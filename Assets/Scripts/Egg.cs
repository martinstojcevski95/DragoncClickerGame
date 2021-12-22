using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Egg : MonoBehaviour
{

    TapManager tapManager;
    public float eggPointOnTap = 1f;
    [SerializeField] Canvas eggCountText;


    // Start is called before the first frame update
    void Start()
    {
        tapManager = (TapManager)FindObjectOfType(typeof(TapManager));
    }

    private void OnMouseDown()
    {
       // tapManager.TapCounter += (int)eggPointOnTap;
        SpawnFoatingTextOnClick();
    }

    void SpawnFoatingTextOnClick()
    {
      var txt =  Instantiate(eggCountText, this.transform.position, Quaternion.identity);
        txt.transform.parent = this.gameObject.transform;
   

     if(txt != null)
        {
            var text = txt.transform.GetChild(0).GetComponent<TMP_Text>();
            text.text = eggPointOnTap.ToString();
          //  txt.transform.DOJump();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
