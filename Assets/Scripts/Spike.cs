using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField]
    private int spikeSpeed;

    void Start()
    {
    }

    void Update()
    {

    }

    void Unfold()
    {
        StartCoroutine(UnfoldCoroutine());
    }

    void Fold()
    {
        StartCoroutine(FoldCoroutine());
    }

    private IEnumerator UnfoldCoroutine()
    {
        float elapsed = 0f;

        while (elapsed < 0.15f)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(transform.position.x, transform.position.y, -1),
                spikeSpeed * Time.deltaTime
            );
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, -1);
    }


    private IEnumerator FoldCoroutine()
    {
        float elapsed = 0f;

        while (elapsed < 0.15f)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(transform.position.x, transform.position.y, -6),
                spikeSpeed * Time.deltaTime
            );
            yield return null;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, -6);
    }
}
