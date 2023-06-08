using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSceneUI : SceneUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["InfoButton"].onClick.AddListener(() => { OpenInfoWindowUI(); });
        buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("Volume"); });
        buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUpUI(); });
    }

    public void OpenPausePopUpUI()
    {
        GameManager.UI.OpenPopUpUI("UI/SettingPopUpUI");
    }

    public void OpenInfoWindowUI()
    {
        GameManager.UI.OpenWindowUI("UI/InfoWindowUI");
    }
}
