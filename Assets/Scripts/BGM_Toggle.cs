using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Toggle : MonoBehaviour
{
    [SerializeField] AudioSource MainBGM;


    bool off;

    private void Start()
    {
        off = false;
    }
    public void BGMSetting()
    {
        if (off == false)
        {
            MainBGM.Stop();
            off = true;
        }
        else
        {
            MainBGM.Play();
            off = false;
        }
    }
}
