using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpCanvasUI : rhkwpPopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["Bu"].onClick.AddListener(() => { GameManager.UI.OpenPopUpUI("UI/rhkwpCanvas1"); });
        buttons["Ta"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
    }
}
