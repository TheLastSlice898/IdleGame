using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject HoverPrefab;
    [SerializeField] private GameObject CurrentHoverOBJ;

    [SerializeField] private GameObject Canvas;

    [SerializeField] private TextMeshProUGUI UWUText;
    [SerializeField] private TextMeshProUGUI UpgradeText;

    public enum HoverType {Shop,Upgrade}
    bool ytes;

    private static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this) 
        { 
        Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
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

    

        UWUText.text = GameManager.Instance.ReturnUwus().ToString();

    }
    public void SpawnUIHover(HoverType type,GameObject HoverObject)
    {


        if (type == HoverType.Shop && CurrentHoverOBJ == null) 
        { 
            var currentUpgrade = HoverObject.GetComponent<UpgradeButton>()._currentUpgrade;
            CurrentHoverOBJ = Instantiate(HoverPrefab,Canvas.transform);
            var hoverscript = CurrentHoverOBJ.GetComponent<HoverSript>();
            hoverscript.name = currentUpgrade.name;
            hoverscript.description = currentUpgrade.Description;
            hoverscript.price = currentUpgrade.Price;
        }
        if (type == HoverType.Upgrade) 
        { 
            var currentUpgrade = HoverObject.GetComponentInParent<UpgradeScript>().CurrentUpgrade;
            CurrentHoverOBJ = Instantiate(HoverPrefab,Canvas.transform);
            var Hoverscript = CurrentHoverOBJ.GetComponent<HoverSript>();
            Hoverscript.name = currentUpgrade.name; 
            Hoverscript.description = currentUpgrade.Description;
            Hoverscript.price = currentUpgrade.Price;
        }
    }
    public void DestroyHover()
    {
        Destroy(CurrentHoverOBJ);
    }
}
