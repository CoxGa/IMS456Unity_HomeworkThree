using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer meshRenderer;


    [SerializeField]
    private Rigidbody rigidbody;


    [SerializeField]
    private bool red = true;


    // Start is called before the first frame update
    void Start()
    {
        red = true;
        meshRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (!red)
        {
            meshRenderer.material.color = Color.blue;
        }

        if (red)
        {
            meshRenderer.material.color = Color.red;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            red = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            red = true;
        }

    }


}
