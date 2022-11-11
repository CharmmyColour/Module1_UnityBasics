using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    
    public float speed;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        Destroy(bullet, 5f);
    }

}