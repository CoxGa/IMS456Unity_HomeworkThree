using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaregtTwo : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer meshRenderer;


    [SerializeField]
    private Rigidbody rigidb;

    public float radius = 10.0F;
    public float power = 500000.0F;





    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 explosionPos = transform.position;

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("BOOM!");
            rigidb.AddExplosionForce(power, explosionPos, radius, 10.0F);
        }
    }

}
