using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorPrebafs : MonoBehaviour
{
    [SerializeField] GameObject MyPrefabs;
    [SerializeField] Transform PosicionInicial;
    Vector3 NewPos;

    float randomX;
    float randomY;
    float separacion;
    float distancia;

    // Start is called before the first frame update
    void Start()
    {
        InicioBolas();
        StartCoroutine("Bucle");
        
    }

    void CrearBolas()
    {
        randomX = Random.Range(-14f, 14f);
        randomY = Random.Range(0, 12);
        Vector3 initPos = new Vector3(randomX, randomY, 0);
        Vector3 NewPos = PosicionInicial.position + initPos;

        //que no lo gire
        Instantiate(MyPrefabs, NewPos, Quaternion.identity);



    }



   void InicioBolas()
    {

        for (int n = 15; n < 15; n++)
        {
            int x = Random.Range(-14, 14);
            int y = Random.Range(0, 12);
            Vector3 CambioPos = new Vector3(x, y, 0);
            Vector3 NewPos = PosicionInicial.position + CambioPos;
            Instantiate(MyPrefabs, NewPos, Quaternion.identity);

        }
    }

    IEnumerator Bucle()
    {
        while (true)
        {


            CrearBolas();
            yield return new WaitForSeconds(0.09f - 0.005f);


        }


    }


}
