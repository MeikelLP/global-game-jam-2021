using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;
    
    private SpriteRenderer _renderer;
    private Transform _t;
    

    private void Start()
    {
        _t = transform;
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        var camPos = cam.transform.position;
        camPos.z = 0;
        _t.position = camPos - camPos * speed;
    }
}