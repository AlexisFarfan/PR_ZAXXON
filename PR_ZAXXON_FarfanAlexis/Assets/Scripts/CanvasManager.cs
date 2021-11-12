using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{

    [SerializeField] Image livesImage;
    [SerializeField] Sprite[] livesSprites;

    [SerializeField] int Lives;

    // Start is called before the first frame update
    void Start()
    {
        //livesImage.sprite = livesSprites[Lives];
    }

    // Update is called once per frame
    void Update()
    {
        //livesImage.sprite = livesSprites[LIves];
    }

    public void IniciarJuego()
    {
        GameManager.playerllifes = 3;
    }
}
