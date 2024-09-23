using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade",order = 1)]
[System.Serializable]
public class Upgrade : ScriptableObject
{
    public string Name;
    public string Description;
    public int Price;
    
    public Sprite image;
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