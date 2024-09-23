using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public double uwus;
    public string SceneName;

    public delegate void IncraseValue();
    public static event IncraseValue Value;

    private static GameManager _Instance;
    public static GameManager Instance { get { return _Instance; } }
    private void Awake()
    {
        if (_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
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


    public void IncraseValie()
    {
        uwus += 1 * UpgradeManager.UManager.TotalMutliplier;
        Value.Invoke();

    }
    public double ReturnUwus()
    {
        return uwus;
    }
}
