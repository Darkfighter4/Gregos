using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PortaErrada")) 
        {
            Debug.Log("Colidiu com a porta errada!"); 
            Die(); 
        }
    }
    
    void Die()
    {
        Debug.Log("Você morreu! Reiniciando a cena...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
