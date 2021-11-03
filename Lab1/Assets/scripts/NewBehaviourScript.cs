using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private int count;

    void Start()
    {
        count = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            count += 1;
            Debug.Log("Collected: " + gameObject.tag + "Points: " + count);

            if (count >= 9)
            {
                Debug.Log("End Game");
                Application.Quit();
            }
        }
        else if (other.gameObject.tag == "Pickup2")
        {
            other.gameObject.SetActive(false);
            count += 4;
            Debug.Log("Collected: " + gameObject.tag + "Points: " + count);

            if (count >= 9)
            {
                Debug.Log("End Game");
                Application.Quit();
            }
        }
    }
}
