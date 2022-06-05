using UnityEngine;
using UnityEngine.SceneManagement;

public class Retour_menu : MonoBehaviour
{

    public string Mainmenu;

    public void RetourMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
