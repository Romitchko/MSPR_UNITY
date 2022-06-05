using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class InputFieldToJson
{
    public string prenom;
    public string mail;
}

public class ButtonPartage : MonoBehaviour
{

    public GameObject Envoyer;
    public InputField Input_prenom;
    public InputField Input_email;
    public Text messageInformationUser;

    void Start()
    {
        Envoyer.gameObject.SetActive(false);
        messageInformationUser.text = "Pour partager, tu dois renseigner ton prénom et ton email !";
    }

    public void PostData() => StartCoroutine(PostData_Coroutine());

    IEnumerator PostData_Coroutine()
    {
        string uri = "http://127.0.0.1:8081/prospect";

        var dataJson = new InputFieldToJson();
        dataJson.prenom = Input_prenom.text.ToString();
        dataJson.mail = Input_email.text.ToString();

        string jsonString = JsonUtility.ToJson(dataJson);
        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonString);

        var req = new UnityWebRequest(uri, "POST");
        req.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
        req.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        req.SetRequestHeader("Content-Type", "application/json");

        //Send the request then wait here until it returns
        yield return req.SendWebRequest();

        if (req.isNetworkError)
        {
            Debug.Log("Error While Sending: " + req.error);
        }
        else
        {
            Debug.Log("Received: " + req.downloadHandler.text);
        }

        //Clear req
        req.Dispose();
    }

    public void buttonAppearance()
    {
        if (Input_prenom.text == "" || Input_email.text == "")
        {
            Envoyer.gameObject.SetActive(false);
            messageInformationUser.gameObject.SetActive(true);
            messageInformationUser.text = "Pour partager, tu dois renseigner ton prénom et ton email !";
        }
        if (Input_prenom.text != "" && Input_email.text != "")
        {
            if (IsValidEmail(Input_email.text))
            {
                Envoyer.gameObject.SetActive(true);
                messageInformationUser.gameObject.SetActive(false);
            }
            else
            {
                messageInformationUser.gameObject.SetActive(true);
                messageInformationUser.text = "Ton email est invalide :(";
            }

        }
    }

    public bool IsValidEmail(string email)
    {
        var trimmedEmail = email.Trim();

        if (trimmedEmail.EndsWith("."))
        {
            return false;
        }
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == trimmedEmail;
        }
        catch
        {
            return false;
        }
    }
}
