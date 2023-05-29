using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirTiros : MonoBehaviour
{
    public float tempodotiro;

    void Start()
    {
        Destroy(this.gameObject, tempodotiro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
