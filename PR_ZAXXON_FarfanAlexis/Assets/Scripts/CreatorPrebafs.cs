using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorPrebafs : MonoBehaviour
{
    [SerializeField] GameObject MyPrefabs;
    [SerializeField] Transform PosicionInicial;
    Vector3 NewPos;

    // Start is called before the first frame update
    void Start()
    {
        for(int n = 0; n <30; n++)
        {
            int x = Random.Range (-18, 18);
            int y = Random.Range(1, 10);
            Vector3 CambioPos = new Vector3(x, y, 0);
            NewPos = PosicionInicial.position + CambioPos;
            Instantiate(MyPrefabs, NewPos, Quaternion.identity);
          
        }

        
    }

   
}
