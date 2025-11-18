using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 50f; //  ������ ������
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime); // ������ ������
    }
}
