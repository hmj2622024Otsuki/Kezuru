using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PropGenerator : MonoBehaviour
{
	[SerializeField] GameObject propPrefab;
	[SerializeField] GameObject Camera;
	Rigidbody rigid;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			GameObject prop = Instantiate(propPrefab);
			rigid = prop.GetComponent<Rigidbody>();

			if (rigid != null)
			{
				// スイカをカメラの位置に持っていく
				prop.transform.position = Camera.transform.position;
				rigid.AddForce(Random.Range(-2, 2), -3, Random.Range(7, 15), ForceMode.Impulse);
			}

			Destroy(prop, 5.0f); // 五秒経ったらクローンを削除
		}

	}
}
