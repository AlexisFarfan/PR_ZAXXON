using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Muerte : MonoBehaviour
{

    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprites;
    [SerializeField] GameObject Game_Over;
    [SerializeField] GameObject naveMesh;
    


    // Start is called before the first frame update
    void Start()
    {
        print(GameManager.playerllifes);
        int lifes = GameManager.playerllifes;
        lifesImage.sprite = lifesSprites[lifes];
    }

    // Update is called once per frame
     void Update()
     {
        
     }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            

            GameManager.playerllifes--;
            if(GameManager.playerllifes == 0)
            {

                //Destroy(this.gameObject);
                naveMesh.SetActive(false);
                Game_Over.SetActive(true);
                Time.timeScale = 0f;
                Game_Over.SetActive(true);
                
                
            }

            else
            {
                int currentscene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentscene);
               
            }
            
            




            //Destroy(this.gameObject);
        }

    }
}
