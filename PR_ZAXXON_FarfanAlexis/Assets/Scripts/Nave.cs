using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Nave : MonoBehaviour
{
    private Vector3 InitPos = new Vector3(0, 4.95f, 0);
    private float speed = 20f;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = InitPos;

    }

    // Update is called once per frame
    void Update()
    {
        
        MoverNave();
       
    }

    void MoverNave()
    {

        float posX = transform.position.x;
        float desplX = Input.GetAxis("Horizontal");
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");


        if (posX < 18 && posX > -18 || desplX > 0 && posX < -18 || posX > 18 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);

        }


        if (posY < 12 && posY > 0.7 || desplY > 0 && posY < 0.7 || posY > 12 && desplY < 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime * desplY, Space.World);

        }
        transform.rotation = Quaternion.Euler(desplY * -20, 0, desplX * -20);

       

    }

   /* private void OnTriggerEnter(Collider other)
    {
        print("choque");
        GameManager.playerllifes--;
    }*/


}
