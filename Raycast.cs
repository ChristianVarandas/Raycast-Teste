using UnityEngine;
using static UnityEngine.Analytics.IAnalytic;

public class Raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hitdata;
    Color cor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            cor = Color.blue;
            Lancar(ray, cor);
        }
    }

    private void Lancar(Ray ray, Color cor)
    {
        Debug.Log("Origem: " + ray.origin);
        Debug.Log("Direção: " + ray.direction);
        

        if (Physics.Raycast(ray, out hitdata))
        {
            GameObject hitObject = hitdata.transform.gameObject;
            string tag = hitdata.collider.tag;
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);


            if (tag == "alvo")
            {
                Destroy(hitObject);
                Debug.Log("Acerto");
            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 1000, Color.blue);
                Debug.Log("Errado");
            }
        }
    }
}
