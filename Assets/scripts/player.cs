using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
 	public Text countText;
   	public Text winText;	
	private Rigidbody rb;
	private int count;
	public float speed;
	void Start()
	{	
        rb=GetComponent<Rigidbody>();
	count = 0;
        SetCountText ();
        winText.text = "";
	}
		
	void FixedUpdate() 
	{
		float horizontal=Input.GetAxis("Horizontal");
		float vertical=Input.GetAxis("Vertical");
		
		Vector3 movement= new Vector3(vertical,0.0f,horizontal);
		rb.AddForce(movement * speed);
	}
		
	/* Adaptacion para el acelerometro del movil */
	/*
	void FixedUpdate ()
	{
		float moveHorizontal = Input.acceleration.x;
		float moveVertical = Input.acceleration.y;
		transform.position += new Vector3 (moveHorizontal, 0.0f, moveVertical)* speed * Time.deltaTime;
	}
	*/
	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick up"))
        {
            other.gameObject.SetActive (false);
	    count = count + 1;
            SetCountText ();
        }
    }
	void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 9)
        {
			Destroy (GameObject.FindGameObjectWithTag ("enemigo"));
            winText.text = "You Win!";
        }
    }

}


