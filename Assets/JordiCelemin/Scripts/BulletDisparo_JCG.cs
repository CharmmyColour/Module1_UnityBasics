using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDisparo_JCG : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
