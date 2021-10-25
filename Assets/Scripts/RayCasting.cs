using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class RayCasting : MonoBehaviour
{
    public GameObject mainCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire(InputValue input)
    {
        var ray = new Ray(mainCam.transform.position, mainCam.transform.forward);
        var rayColor = Color.blue;
        var rayDist = 2000.0f;
        if (Physics.Raycast(ray, out var hit, rayDist))
        {
            rayColor = Color.red;
            if (hit.collider.gameObject.tag == "Target")
            {

                Destroy(hit.collider.gameObject);
            }




            //Debug.Log("hit"+ (hit.collider.name));
        }
        Debug.DrawRay(ray.origin, ray.direction * rayDist, rayColor, 0.5f);
    }
}
