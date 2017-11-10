using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogueSpeedConverter : MonoBehaviour
{
    public float RotationsSpeed = 2;
    public float minAmount;
    public float maxAmount;
    public float minAngle;
    public float maxAngle;
    public GameObject thisSpeedo;

	// Use this for initialization
	void Start ()
	{
	    
	}

    void Rotation(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0,0,ang);
    }
	
	// Update is called once per frame
	void Update () {
		Rotation(RotationsSpeed, minAmount,maxAmount);
	}
}
