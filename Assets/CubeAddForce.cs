using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAddForce : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float Force;

    // Start is called before the first frame update
    void Start()
    {
        _rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SendIt()
    {
        Vector3 randomvector = Random.rotation.eulerAngles;
        _rb.AddTorque(randomvector, ForceMode.VelocityChange);
    }
    public void OnEnable() => GameManager.Value += SendIt;
    public void OnDisable() => GameManager.Value -= SendIt;
}
