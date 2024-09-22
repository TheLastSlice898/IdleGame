using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI UWUText;
    [SerializeField] private TextMeshProUGUI UpgradeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        UWUText.text = GameManager.Instance.ReturnUwus().ToString();



    }
}
