using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public string Scan_Singe;
    public string Scan_Serpent;
    public string Scan_Rhino;

    public void ScanSinge()
    {
        SceneManager.LoadScene("Scan_Singe");
    }

    public void ScanSerpent()
    {
        SceneManager.LoadScene("Scan_Serpent");
    }

    public void ScanRhino()
    {
        SceneManager.LoadScene("Scan_Rhino");
    }

    public void Quitter()
    {
        Application.Quit();
    }

}
