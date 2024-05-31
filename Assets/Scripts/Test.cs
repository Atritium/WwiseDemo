using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkBankManager.LoadBank("BgmSoundBank", false, false);
        AkSoundEngine.PostEvent("Play_Dicemon_Theme", gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
