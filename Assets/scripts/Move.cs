using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(speed);

    }

    // Update is called once per frame
    void Update()
    {   
        if(Keyboard.current.upArrowKey.isPressed)
        {
            Vector3 direction = new Vector3(0, 1, 0);
            transform.Translate(direction * speed * Time.deltaTime);
        }

        if(Keyboard.current.downArrowKey.isPressed)
        {
            Vector3 direction = new Vector3(0, -1, 0);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        
    }
}
