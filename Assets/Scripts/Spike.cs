using UnityEngine;

public class Spike : MonoBehaviour
{
    public int spikeSpeed;

    void Start() { }

    void Update() { }

    void Unfold()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(transform.position.x, transform.position.y, -1),
            spikeSpeed * Time.deltaTime
        );
    }

    void Fold()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(transform.position.x, transform.position.y, -6),
            spikeSpeed * Time.deltaTime
        );
    }
}
