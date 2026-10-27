using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
	int HP = 100;
	[SerializeField] GameObject HealthTxt;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60;
	}

	private void Update()
	{
		HealthTxt.GetComponent<TextMeshProUGUI>().text = "HP:" + HP.ToString("F0");
	}
}
