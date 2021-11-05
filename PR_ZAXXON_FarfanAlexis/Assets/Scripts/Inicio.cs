using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{

    // Start is called before the first frame update
    public void IniciarJuego()
    {
        // configvars.numlives = 3;

        SceneManager.LoadScene(1);
    }

    public void IniciarOptions()
    {
       

        SceneManager.LoadScene(3);
    }

    public void IniciarHallOfFame()
    {
       

        SceneManager.LoadScene(4);
    }
}
