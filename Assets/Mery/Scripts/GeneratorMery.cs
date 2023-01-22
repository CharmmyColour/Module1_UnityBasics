using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMery : MonoBehaviour
{
    public GameObject pipe;
    public Transform waypoint;

    public float cooldown;
    private float resetCooldown;
    
    private void Start()
    {
        resetCooldown = cooldown; 
    }

    private void Update()
    {
        cooldown = cooldown - 1 * Time.deltaTime;

        if (cooldown < 0)
        {
            Instantiate(pipe, waypoint);
            cooldown = resetCooldown;         
        }
    }
}
