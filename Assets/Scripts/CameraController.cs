using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float maxOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Vector3.Distance(transform.position, player.position)) > maxOffset)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, maxOffset);
        }
    }
}
