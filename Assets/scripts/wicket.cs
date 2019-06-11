using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wicket : MonoBehaviour
{

    Vector3 initialPos;
    public Transform scoreTrans;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score += 1;
            scoreTrans.GetComponent<Text>().text = (score/2).ToString();
            Debug.Log(score);
            
        }
    }

    public void repacing()
    {
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = initialPos;
        }
    }


}
