using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInGameUI : InGameUI
{
    public TowerPlace towerPlace;

    protected override void Awake()
    {
        base.Awake();

        buttons["Block"].onClick.AddListener(() => { GameManager.UI.CloseInGameUI<InGameUI>(this); });
        buttons["Archer"].onClick.AddListener(() => { BuildArcherTower(); });
        buttons["Canon"].onClick.AddListener(() => { BuildCanonTower(); });
    }

    public void BuildArcherTower()
    {
        TowerData archerTowerData = GameManager.Resource.Load<TowerData>("Data/ArcherTowerData");
        towerPlace.BuildTower(archerTowerData);
        GameManager.UI.CloseInGameUI(this);
    }

    public void BuildCanonTower()
    {
        TowerData canonTowerData = GameManager.Resource.Load<TowerData>("Data/CanonTowerData");
        towerPlace.BuildTower(canonTowerData);
        GameManager.UI.CloseInGameUI(this);
    }
}
