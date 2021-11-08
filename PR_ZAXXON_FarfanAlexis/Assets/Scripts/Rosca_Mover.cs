using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rosca_Mover : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    float posZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed = speed + 0.1f;

        posZ = transform.position.z;

        if (posZ < -20)
        {
            Destroy(gameObject);

        }

        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
