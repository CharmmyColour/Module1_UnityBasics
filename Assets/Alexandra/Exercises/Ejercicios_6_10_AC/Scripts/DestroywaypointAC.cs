using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroywaypointAC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1f);        //que se destruya cuando pase 1segundo
    }
}
