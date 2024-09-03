using System;
using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;

public class DBConnector : MonoBehaviour
{
    private const string FireBaseURL = "https://simuladores-1-7f26a-default-rtdb.firebaseio.com/";

    public static DBConnector instance;

    private void Awake()
    {
        instance = this;
    }

    public string formatUrl(string endpoint)
    {
        return "https://simuladores-1-7f26a-default-rtdb.firebaseio.com/" + "TEST" + "/" + endpoint + ".json";
    }
        
    public void GetJson(string endpoint, Action<ResponseHelper> callback, Action<Exception> errorCallback)
    {
        RestClient.Get(formatUrl(endpoint)).Then(handleResponse).Catch(handleError);
    }

    private void handleResponse(ResponseHelper responseHelper)
    {
        Debug.Log(responseHelper.Text);
    }

    private void handleError(Exception error)
    {
        Debug.Log(error.Message);
    }
}
