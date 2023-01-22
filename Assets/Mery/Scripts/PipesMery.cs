using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMery : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        this.transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, -40.5f, -45f);
    }
}
