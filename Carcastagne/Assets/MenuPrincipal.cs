using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void LancerLeJeu()
    {
        SceneManager.LoadScene("SceneVictor");
    }
    
    public void QuitGame()
    /* Permet de fermer l'application. Est appeler par le bouton "Quitter" du Menu Principal */
    {
        Debug.Log("Quitter !");
        Application.Quit();
    }
}
