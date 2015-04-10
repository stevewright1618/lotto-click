using UnityEngine;
using System.Collections;

public class NumberFly : MonoBehaviour
{
    public GameObject NumberPrefab;

    void OnMouseDown()
    {
        GameObject Num1 = Instantiate(NumberPrefab) as GameObject;
        //Num1.transform.parent = gameObject.transform;
        Num1.transform.position = gameObject.GetComponent<Collider2D>().bounds.center;
        Vector3 vec = new Vector3 (Num1.transform.position.x, Num1.transform.position.y, -2f);
        Num1.transform.position = new Vector3(vec.x - (float)(GetComponent<Collider2D>().bounds.size.x / 2), vec.y + (float)(GetComponent<Collider2D>().bounds.size.y / 2));

        int[] numbers = getRandoms(-10, 10, 2);

        Vector3 randomVelocities = new Vector3((float)numbers[0], (float)numbers[1]);

        Num1.GetComponent<Rigidbody>().velocity = randomVelocities;
        Num1.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, (float)getRandoms(-30, 30, 1)[0]);

        Physics2D.IgnoreCollision(Num1.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    private int[] getRandoms(int min, int max, int size)
    {
        int[] output = new int[size];

        for (int i = 0; i < size; i++)
        {
            output[i] = Random.Range(min, max);
        }

        return output;
    }
}