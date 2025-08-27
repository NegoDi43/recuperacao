using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void menu ()
    {
        SceneManager.LoadScene("Menu");
    }
    public void game()
    {
        SceneManager.LoadScene("Plataforma");
    }
  
}
