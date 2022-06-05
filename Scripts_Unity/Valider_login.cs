using UnityEngine;
using UnityEngine.SceneManagement;

public class Valider_login : MonoBehaviour
{

    public string Mainmenu;

    public void RetourMenuDepuisLogin()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
