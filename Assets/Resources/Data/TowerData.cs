using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")]

public class TowerData : ScriptableObject
{
    [SerializeField]
    public TowerInfo[] towers;

    

    [Serializable]
    public class TowerInfo
    {
        public Tower tower;

        public float Damage;
        public float dilay;
        public float Range;

        public float buildTime;
        public int buildCost;
        public int sellCost;
    }
}
