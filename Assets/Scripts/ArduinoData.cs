using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJson;

[Serializable]
public class ArduinoData : MonoBehaviour
{

    public static Temp MyTemp;

	// Use this for initialization
	void Start () {
	    StartCoroutine(GetText());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator GetText()
    {
        while (true)
        {
            UnityWebRequest www = UnityWebRequest.Get("http://192.168.178.108/");
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                //Debug.Log(www.downloadHandler.text);
                string json = JsonUtility.ToJson(www.downloadHandler.text);
                MyTemp = JsonUtility.FromJson<Temp>(www.downloadHandler.text);
                Debug.Log(www.downloadHandler.text);
                Debug.Log("Json: " + json);
                Debug.Log("temp0 " + MyTemp.temp0);
                //Debug.Log(t.temp1);
                //Debug.Log(t.temp2);
                //Debug.Log(t.temp3);
                //Debug.Log(t.temp4);
                //Debug.Log(t.temp5);


                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }
}
