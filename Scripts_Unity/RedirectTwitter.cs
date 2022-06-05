using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectTwitter : MonoBehaviour
{

    public string Mainmenu;

    public void redirectTwitter()
    {
#if PLATFORM_ANDROID
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.twitter.android");
#else
        Application.OpenURL("https://apps.apple.com/us/app/twitter/id333903271");
    }
#endif
}}