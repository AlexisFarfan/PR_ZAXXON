using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{

    // Start is called before the first frame update
    public void IniciarJuego()
    {
       
        GameManager.playerllifes = 3;
        SceneManager.LoadScene(1);
    }

    public void IniciarOptions()
    {
       

        SceneManager.LoadScene(2);
    }

    public void IniciarRanking()
    {
       

        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
        //Debug.Log("se cerro el juego");
    }
}
