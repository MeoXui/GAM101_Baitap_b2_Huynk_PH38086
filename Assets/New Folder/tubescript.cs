using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubescript : MonoBehaviour
{
    public float tocDoDiChuyen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * tocDoDiChuyen * Time.deltaTime *2);
    }
}
