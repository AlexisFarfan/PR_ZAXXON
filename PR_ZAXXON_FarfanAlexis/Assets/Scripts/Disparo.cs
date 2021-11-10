using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform spawnpoint;

    public float shootForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Time.time>shotRateTime)
            {
                GameObject nuevaBala;

                nuevaBala = Instantiate(bala, spawnpoint.position, spawnpoint.rotation);

                nuevaBala.GetComponent<Rigidbody>().AddForce(spawnpoint.forward * shootForce);

                shotRateTime = Time.time + shotRate;

                Destroy(nuevaBala,2);
            }
        }
    }
}
