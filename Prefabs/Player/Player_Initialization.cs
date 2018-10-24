using UnityEngine;

public class Player_Initialization : MonoBehaviour
{
    public GameObject Terrain;

    void Start()
    {
        transform.position = new Vector3(40, 3.5F, 10);
    }
}
