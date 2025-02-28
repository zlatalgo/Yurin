using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezeSpeed = 0.05f;
    public int playerDamage = 2;
    public Health health;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if (temperatureCurrent <= temperatureCritical)
        {
            freezeDamageTimer -= Time.deltaTime;
            if(freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer = freezeDamageDelay;
            }
        }
    }
}
