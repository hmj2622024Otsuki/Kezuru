using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PropGenerator : MonoBehaviour
{
	[SerializeField] GameObject propPrefab;
	//Rigidbody rigid3D;

	//void Shoot(Vector3 dir)
	//{
	//	rigid3D.AddForce(dir);
	//	Shoot(new Vector3(0, 200, 2000)
	//});

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigid3D = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			GameObject prop = Instantiate(propPrefab);
			Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.value);
			//Shoot(ray.direction * 2000);
		}

	}
}
