using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletAC : MonoBehaviour
{
    //move bullet
    public float Speed;         //menci�n par�metro velocidad

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;   //mover bullet
    }

}
