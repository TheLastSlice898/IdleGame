using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade",order = 1)]
[System.Serializable]
public class Upgrade : ScriptableObject
{
    public string Name;
    public string Description; 
    public UpgradeType.type upgradeType;
    public int Lvl;
    public float multiplier;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class UpgradeType 
{
    public enum type {Classic,boost}
}
