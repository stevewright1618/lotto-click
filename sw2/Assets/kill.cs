using UnityEngine;
using System.Collections;

public class kill : MonoBehaviour 
{
    private int frameCount = 0;
    private float secondsPassed = 0f;
    public int maxSeconds;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
    {
        frameCount++;
        secondsPassed += (float)(Time.deltaTime);

        if (secondsPassed >= maxSeconds)
            Destroy(gameObject);
	}
}
