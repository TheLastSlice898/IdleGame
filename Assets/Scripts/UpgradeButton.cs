using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[System.Serializable]
public class ShopButtonColors
{
    [Header("Colours for Can Afford")]
    public ColorBlock Afford = ColorBlock.defaultColorBlock;
    [Header("Colours for Cant Afford")]
    public ColorBlock CantAfford = ColorBlock.defaultColorBlock;
}

public class UpgradeButton : MonoBehaviour, IPointerMoveHandler, IPointerEnterHandler, IPointerExitHandler
{


    [SerializeField] private Image _img;
    [SerializeField] private Button _b;
    [SerializeField] private TextMeshProUGUI _p;
    public ShopButtonColors ShopColours;

    public Upgrade _currentUpgrade;

    public delegate void SendPointerData(PointerEventData eventData);
    public static event SendPointerData PointerData;

    public bool canAfford;
    public int Price;

    [SerializeField] private bool ishovered;

    // Start is called before the first frame update
    void Start()
    {

        Price = _currentUpgrade.Price;
        _p.text = Price.ToString();
        _img.sprite = _currentUpgrade.image;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Price <= GameManager.Instance.ReturnUwus())
        {
            _b.colors = ShopColours.Afford;
            _p.color = Color.green;

        }
        else
        {
            _b.colors = ShopColours.CantAfford;
            _p.color = Color.red;
        }
    }
    public void BuyUpgrade()
    {
            
    }
    public void OnPointerEnter(PointerEventData evendata)
    {
        ishovered = true;
        

    }
    public void OnPointerMove(PointerEventData eventData)
    {
        if (eventData != null) 
        {
            UIManager.Instance.SpawnUIHover(UIManager.HoverType.Shop, gameObject);
            PointerData.Invoke(eventData);
        }
    }
    
    public void OnPointerExit(PointerEventData evendata)
    {
        ishovered = false;
        UIManager.Instance.DestroyHover();
    }
}
