using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearRoscas : MonoBehaviour
{
    [SerializeField] GameObject MyPrefabs;
    [SerializeField] Transform PosicionInicial;
    Vector3 NewPos;
    float randomZ;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Bucle");
    }

    void CreaRoscas()
    {
        
        Vector3 initPos = new Vector3(0, 0, 0);
        Vector3 NewPos = PosicionInicial.position + initPos;

        //que no lo gire
        Instantiate(MyPrefabs, NewPos, Quaternion.identity);



    }



    // Update is called once per frame
    IEnumerator Bucle()
    {
        while (true)
        {


            CreaRoscas();
            yield return new WaitForSeconds(2f);


        }


    }
}
