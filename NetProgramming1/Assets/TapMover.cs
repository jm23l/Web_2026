using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapMover : MonoBehaviour, IPointerDownHandler
{
    public Transform player;
    public float speed = 8f;
    private Vector3 target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { target = player.position; }

    public void OnPointerDown(PointerEventData e)
    {
        target = Camera.main.ScreenToWorldPoint(e.position);
        target.z = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        player.position = Vector3.MoveTowards(
            player.position, target,speed * Time.deltaTime);   
    }
}
