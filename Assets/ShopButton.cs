using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ShopButtonColors
{
    [Header("Colours for Can Afford")]
    public ColorBlock Afford = ColorBlock.defaultColorBlock;
    [Header("Colours for Cant Afford")]
    public ColorBlock CantAfford = ColorBlock.defaultColorBlock;
}

public class ShopButton : MonoBehaviour
{


    private Button _b;

    public ShopButtonColors ShopColours;

    public Upgrade _currentUpgrade;


    public bool canAfford;
    public int Price;

    
    // Start is called before the first frame update
    void Start()
    {
        _b = GetComponentInChildren<Button>();
        Price = _currentUpgrade.Price;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Price <= GameManager.Instance.ReturnUwus())
        {
            canAfford = true;
            _b.colors = ShopColours.Afford;
            
        }
        else
        {
            canAfford = false;
            _b.colors = ShopColours.CantAfford;
        }
    }
    public void BuyUpgrade()
    {
            
    }
}
