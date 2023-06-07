using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpSettingSceneUI : rhkwpSceneUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["White"].onClick.AddListener(() => { Debug.Log("info"); });
        buttons["Red"].onClick.AddListener(() => { Debug.Log("Volume"); });
        buttons["Black"].onClick.AddListener(() => { OpenPausePopUpUI(); });
    }

    public void OpenPausePopUpUI()
    {
        GameManager.UI.OpenPopUpUI("UI/rhkwpCanvas");
    }
}
