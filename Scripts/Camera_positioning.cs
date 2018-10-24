using UnityEngine;

public class Camera_positioning : MonoBehaviour
{

    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Player.transform.position.x, 10, 2);
    }

    void Update()
    {
        if (Player.transform.position.x != transform.position.x)
        {
            Start();
        }    
    }
}
