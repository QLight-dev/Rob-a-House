using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputSystem_Actions controls;
    public int speed = 10;

    void Awake()
    {
        controls = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    void Start()
    {
        transform.position = new Vector3(0, 1.5f, 0);
    }

    void Update()
    {
        Vector2 moveInput = controls.Player.Move.ReadValue<Vector2>();
        transform.Translate(
            moveInput.x * speed * Time.deltaTime,
            0,
            moveInput.y * speed * Time.deltaTime
        );

        if (transform.position.z > 4.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 4.5f);
        }
        if (transform.position.z < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4.5f);
        }

        if (transform.position.x > 15.95f)
        {
            transform.position = new Vector3(15.95f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -15.95f)
        {
            transform.position = new Vector3(-15.95f, transform.position.y, transform.position.z);
        }
    }
}
