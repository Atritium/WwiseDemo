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
        AkSoundEngine.PostEvent("Dicemon_Theme", gameObject);
        AkSoundEngine.ExecuteActionOnEvent("Dicemon_Theme", AkActionOnEventType.AkActionOnEventType_Pause, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
