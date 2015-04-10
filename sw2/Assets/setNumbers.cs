using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class setNumbers : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        TextMesh mesh = GetComponent<TextMesh>();

        string output = getNumbers();

        Debug.Log(output);

        mesh.text = output;
	}

    private string getNumbers()
    {
        int[] output = new int[6];
        string outputs = "";

        for(int i = 0; i < output.Length; i++)
        {
            if(i < 5)
            {
                output[i] = Random.Range(1, 60);
                outputs += output[i] + " ";
            }
            if(i == 5)
            {
                output[i] = Random.Range(1, 36);
            }

            



        }

        int index = 0;
        foreach(int i in output)
        {
            Debug.Log(i);

             List<int> elements = output.<int>(index) as List<int>;

             Debug.Log(elements);

            if (elements.Any(x => x == elements[index]))
                return getNumbers();
        
            index++;
        }

        return outputs;
    }
}
