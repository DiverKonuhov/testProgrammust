using UnityEngine;

public class begin : MonoBehaviour
{
    GameObject Player;
    public float speed = 1f;
    //[SerializeField]
    //public float moveHorizontal_X;
    //[SerializeField]
    //public float moveAltitude_Y;
    //[SerializeField]
    //public float moveVertical_Z;
    //[SerializeField]
    //private Transform targetTransform;


    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        Transform PlayerTransform = Player.transform;
        if (Input.GetKey(KeyCode.W))
        {
            PlayerTransform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTransform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.position += new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.position += new Vector3(0, 0, -speed);
        }
    }
}
