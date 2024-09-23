using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverSript : MonoBehaviour
{
    public string name;
    public string description;
    public int price;
    [SerializeField] private TextMeshProUGUI nameUGUI;
    [SerializeField] private TextMeshProUGUI descriptionUGUI;
    [SerializeField] private TextMeshProUGUI priceUGUI;


    private RectTransform RectTransform;
    // Update is called once per frame
    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }
    void Start()
    {
        nameUGUI.text = name;
        descriptionUGUI.text = $"”{description}”";
        priceUGUI.text = price.ToString();
    }
    private void Update()
    {
        if (GameManager.Instance.ReturnUwus() >= price)
        {
            priceUGUI.color = Color.green;
        }
        else
        {
            priceUGUI.color = Color.red;
        }
    }
    void UpdatePosition(PointerEventData eventData)
    {
        if (eventData != null) 
        {
            RectTransform.anchoredPosition = eventData.position;
        }

    }
    private void OnEnable()
    {

        UpgradeScript.PointerData += UpdatePosition;
        UpgradeButton.PointerData += UpdatePosition;
    }
    private void OnDestroy()
    {
        UpgradeScript.PointerData -= UpdatePosition;
        UpgradeButton.PointerData -= UpdatePosition;
    }
}
