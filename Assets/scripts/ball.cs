using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 initialPos;

    wicket wkt = new wicket();

    public static int spin;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("wall"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = initialPos;
            wkt.repacing();
        }
    }

    public void leftspinthree()
    {
        spin = -3;
    }

    public void leftspintwo()
    {
        spin = -2;
    }

    public void leftspinone()
    {
        spin = -1;
    }

    public void nospin()
    {
        spin = 0;
    }

    public void rightspinone()
    {
        spin = 1;
    }

    public void rightspintwo()
    {
        spin = 2;
    }

    public void rightspinthree()
    {
        spin = 3;
    }


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pitch") && (spin == -3))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 3); 
        }

        if (other.CompareTag("Pitch") && (spin == -2))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 2);
        }

        if (other.CompareTag("Pitch") && (spin == -1))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 1);
        }

        if (other.CompareTag("Pitch") && (spin == 0))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 0);
        }

        if (other.CompareTag("Pitch") && (spin == 1))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, -1);
        }

        if (other.CompareTag("Pitch") && (spin == 2))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, -2);
        }

        if (other.CompareTag("Pitch") && (spin == 3))
        {
            transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, -3);
        }

        spin = 0;
    }
    
}
