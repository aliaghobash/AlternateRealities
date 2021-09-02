using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarData : MonoBehaviour
{
    public Color color = Color.white;

    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Awake()
    {

        meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        meshRenderer.material.color = color; 
    }
}
