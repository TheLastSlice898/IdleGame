using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class cuberotate : MonoBehaviour
{


    public float lerp;
    public float speed;


    private Quaternion DestinationRotation;

    private void OnEnable()
    {
        GameManager.Value += RotateCube;
    }
    private void OnDisable()
    {
        GameManager.Value -= RotateCube;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (lerp > 0)
        {   
            transform.rotation = Quaternion.Slerp(Quaternion.Euler(0,0,0), DestinationRotation, lerp);
            
            lerp -= Time.deltaTime * speed;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            lerp = 0f;
        }
    }


    public void RotateCube()
    {
        Debug.Log("yippee");
        lerp = 1f;
        DestinationRotation = Random.rotation;
    }

}
