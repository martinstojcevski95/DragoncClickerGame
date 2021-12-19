using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyJumpyText : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
       Destroy(this.gameObject, 0.4f);

    }
}
