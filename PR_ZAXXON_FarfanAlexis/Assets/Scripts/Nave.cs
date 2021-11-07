using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private Vector3 InitPos = new Vector3(0, 4.95f, 0);
    [SerializeField] float speed = 15f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = InitPos;

    }

    // Update is called once per frame
    void Update()
    {
        float moverY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * moverY * Time.deltaTime);


        float moverX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * moverX * Time.deltaTime);

        if (Input.GetButton("Fire1"))
        {
            print("disparo");
        }
    }
}
