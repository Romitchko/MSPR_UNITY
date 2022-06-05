using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectFacebook : MonoBehaviour
{

    public string Mainmenu;

    public void redirectFacebook()
    {
#if PLATFORM_ANDROID
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.facebook.katana");
#else
        Application.OpenURL("https://apps.apple.com/us/app/facebook/id284882215");
    }
#endif
}
}