using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirigerPartager : MonoBehaviour
{
    public string FormLogin;

    public void RedirectFenetrePartage()
    {
        SceneManager.LoadScene("FormLogin");
    }
}