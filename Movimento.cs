using UnityEngine;

public class Movimento : MonoBehaviour
{
    public enum Rotacao{
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public Rotacao axes = Rotacao.MouseXandY;
    public float sensityvert = 5f;
    public float sensityhor = 5f;
    public float miniVert = -45.0f;
    public float maxiVert = 45.0f;
    private float _rotacaoX = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody body = GetComponent < Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == Rotacao.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensityhor, 0);
        }
        else if (axes == Rotacao.MouseY)
        {
            _rotacaoX -= Input.GetAxis("Mouse Y") * sensityvert;
            _rotacaoX = Mathf.Clamp(_rotacaoX, miniVert, maxiVert);
            float rotationY = transform.localEulerAngles.y; 
            transform.localEulerAngles = new Vector3(_rotacaoX, rotationY, 0);
        }
        else
        {
            _rotacaoX -= Input.GetAxis("Mouse Y") * sensityvert;
            _rotacaoX = Mathf.Clamp(_rotacaoX, miniVert, maxiVert);
            float delta = Input.GetAxis("Mouse X") * sensityhor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotacaoX, rotationY, 0);
        }
    }
}
