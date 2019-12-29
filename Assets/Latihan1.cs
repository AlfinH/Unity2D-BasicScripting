using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Fungsi Awake dipanggil");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fungsi Start dipanggil");
    }

    void FixedUpdate()
    {
        Debug.Log("Fungsi FixedUpdate dipanggil");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Fungsi Update dipanggil");
    }

    void LateUpdate()
    {
        Debug.Log("Fungsi LateUpdate dipanggil");
    }

}
