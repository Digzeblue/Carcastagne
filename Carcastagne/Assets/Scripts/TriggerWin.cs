using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerWin : MonoBehaviour
{

    public GameObject victoire;
    public GameObject boutonMenu;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cochon")
        {
            victoire.gameObject.SetActive(true);
            boutonMenu.gameObject.SetActive(true);
            //victoireQueen.SetActive(true);
        }
    } 
    
    public void RetourMenu()
    {
        SceneManager.LoadScene("SceneRubens");
    }


}
