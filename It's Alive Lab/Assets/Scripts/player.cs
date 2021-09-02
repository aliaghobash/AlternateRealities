using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10.0f; 
    // Start is called before the first frame update
  
    Rigidbody body;
    MeshRenderer meshRenderer;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 randDir = Random.onUnitSphere;
        body.AddForce(new Vector3(randDir.x, 0,randDir.y)*speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pillar"))
        {
            PillarData data = collision.gameObject.GetComponent<PillarData>();
            if (data != null)
            {
                meshRenderer.material.color = data.color; 

            }

            Debug.Log("Collision start" + collision.gameObject.name);
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision stay"+ collision.gameObject.name);

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision exit" + collision.gameObject.name);
    }
}
