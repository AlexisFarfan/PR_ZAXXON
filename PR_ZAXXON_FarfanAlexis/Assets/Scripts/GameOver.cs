using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void IniciarPlayAgain()
    {


        SceneManager.LoadScene(1);
    }

    public void IniciarScore()
    {


        SceneManager.LoadScene(4);
    }

    public void IniciarHome()
    {


        SceneManager.LoadScene(0);
    }


}
