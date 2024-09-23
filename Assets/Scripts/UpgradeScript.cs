using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    public Upgrade CurrentUpgrade;

    [SerializeField] private Image Image;
    [SerializeField] private TextMeshProUGUI nameofupgrade;
    [SerializeField] private TextMeshProUGUI lvl;

    public delegate void SendPointerData(PointerEventData eventData);
    public static event SendPointerData PointerData;
    private bool ishovered;
    // Start is called before the first frame update
    void Start()
    {
        Image.sprite = CurrentUpgrade.image;
        nameofupgrade.text = CurrentUpgrade.name;   
        
    }

    // Update is called once per frame
    void Update()
    {
        lvl.text = CurrentUpgrade.Lvl.ToString();
    }
    public void OnPointerEnter(PointerEventData evendata)
    {

        ishovered = true;

        Debug.Log(evendata.position);
        UIManager.Instance.SpawnUIHover(UIManager.HoverType.Upgrade, gameObject);

    }
    public void OnPointerMove(PointerEventData eventData)
    {
        PointerData.Invoke(eventData);
    }

    public void OnPointerExit(PointerEventData evendata)
    {
        ishovered = false;
        UIManager.Instance.DestroyHover();
    }
}
