using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public GameObject RightArrow;
    public GameObject LeftArrow;

    
    // Use this for initialization
	void Start ()
	{
	    StartCoroutine(Blink());

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

    public IEnumerator Blink()
    {
        while (true)
        {
            RightArrow.SetActive(false);
            LeftArrow.SetActive(true);

            yield return new WaitForSeconds(.5f);

            RightArrow.SetActive(true);
            LeftArrow.SetActive(false);

            yield return new WaitForSeconds(.5f);
        }
    }
}
