using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowClose : MonoBehaviour
{
    [SerializeField] GameObject Window;

    public void OnClickExit()
    {
        Window.SetActive(false);
    }
}
