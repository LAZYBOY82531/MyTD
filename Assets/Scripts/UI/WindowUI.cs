using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowUI : BaseUI, IDragHandler, IPointerDownHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta;
    }

    protected override void Awake()
    {
        base.Awake();

        buttons["XButton"].onClick.AddListener(() => { GameManager.UI.CloseWindowUI(this); });
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.UI.SelectWindowUI(this);
    }

}
