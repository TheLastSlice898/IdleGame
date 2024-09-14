using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public List<Upgrade> Upgrades;
    [SerializeField] private Transform Content;
    [SerializeField] private GameObject UpgradePrefab;

    public int TotalUpgrades;
    public float TotalMutliplier;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewUpgrade(Upgrade newupgrade, UpgradeType type)
    {
        TotalUpgrades++;

        foreach (var currentupgrade in Upgrades) 
        { 
        if (newupgrade.name == currentupgrade.name)
            {
                currentupgrade.Lvl++;
            }
            else
            {
                Upgrades.Add(currentupgrade);
            }
        }

    }
    public float ReturnMultipiler => TotalMutliplier;

}
