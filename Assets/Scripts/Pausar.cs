using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;
using System;

public class Pausar : MonoBehaviour
{
    public GameObject panel;
    public StarterAssetsInputs control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(string.Format("El valor ahora es :{0}",Convert.ToInt32(panel.activeSelf)));
            panel.SetActive(!panel.activeSelf);
            //Time.timeScale = panel.activeSelf ? 0 : 1;
            Time.timeScale = Convert.ToInt32(!panel.activeSelf);
            control.cursorInputForLook = !control.cursorInputForLook;
            control.cursorLocked = !control.cursorLocked;
        }
        
    }
}
