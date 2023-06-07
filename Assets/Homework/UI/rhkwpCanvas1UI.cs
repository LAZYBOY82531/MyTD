using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpCanvas1UI : rhkwpPopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["Buta"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
    }
}
