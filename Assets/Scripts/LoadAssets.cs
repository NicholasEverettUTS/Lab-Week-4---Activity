using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public Material redObj;
    // Start is called before the first frame update
    void Start()
    {
        redObj = gameObject.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
