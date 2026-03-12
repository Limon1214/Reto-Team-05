using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject sphereToSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     GameObject newGameObject = Instantiate(sphereToSpawn);
    //     newGameObject.transform.position = transform.position;
    // }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject newGameObject = Instantiate(sphereToSpawn);
            newGameObject.transform.position = 
            transform.position + new Vector3(Random.Range(-0.1f, 0.1f),
            0,
            Random.Range(-0.1f, 0.1f)) ;
        }
        
    }
}
