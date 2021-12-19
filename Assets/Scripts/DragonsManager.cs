using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class DragonsManager : MonoBehaviour
{


    [SerializeField]
    List<GameObject> DragonPrefs = new List<GameObject>();
    public int dragonsCount;
    [SerializeField] GameObject DragonPlatformHolder;
    [SerializeField] RectTransform test;

    // Start is called before the first frame update
    void Start()
    {

        dragonsCount = 1;
        DragonPrefs.ForEach(item => item.SetActive(false));
        DragonPrefs[0].SetActive(true);
       // test.GetComponent<RectTransform>().DOLocalMoveX(2500f, 0.5f, false);
    }


    // Update is called once per frame
    void Update()
    {

    }


    public void CycleDragons()
    {
        DragonPlatformHolder.transform.DOLocalMove(new Vector3(1500f, 0.78f, 0), 0.4f, false).onComplete += ShowDragon;

   
    }

    private void ShowDragon()
    {
        DragonPlatformHolder.transform.DOLocalMove(new Vector3(-146f, 0.28f, 0), 0.5f, false);
        DragonPrefs.ForEach(item => item.SetActive(false));
        DragonPrefs[dragonsCount].SetActive(true);

        dragonsCount++;
        if (dragonsCount >= DragonPrefs.Count)
            dragonsCount = 0;


    }


    public void PreviousDragon()
    {
        DragonPlatformHolder.transform.DOLocalMove(new Vector3(-1900f, 0.78f, 0), 0.4f, false).onComplete += ShowPrevDragon;



        //  





        //   if (dragonsCount >= DragonPrefs.Count)
        // dragonsCount = 0;
    }

    private void ShowPrevDragon()
    {
        DragonPlatformHolder.transform.DOLocalMove(new Vector3(-146f, 0.28f, 0), 0.5f, false);
        DragonPrefs.ForEach(item => item.SetActive(false));
        dragonsCount--;

        DragonPrefs[dragonsCount - 1].SetActive(true);
    }
}
