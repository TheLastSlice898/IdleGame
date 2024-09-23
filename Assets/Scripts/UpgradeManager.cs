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

    private static UpgradeManager _UManager;

    public static UpgradeManager UManager { get { return _UManager; } }

    private void Awake()
    {
        if (_UManager != null && _UManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _UManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


    }
    public void NewUpgrade(Upgrade newupgrade)
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
