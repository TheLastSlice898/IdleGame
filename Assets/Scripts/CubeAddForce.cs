using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float Force;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SendIt()
    {
        float rand = Random.Range(0.7f, 2f);
        _audioSource.pitch = rand;
        _audioSource.Play();
        Vector3 randomvector = Random.rotation.eulerAngles;
        _rb.AddTorque(randomvector, ForceMode.VelocityChange);
        _rb.AddForce(randomvector * Force, ForceMode.VelocityChange);
    }
    public void OnEnable() => GameManager.Value += SendIt;
    public void OnDisable() => GameManager.Value -= SendIt;
}
