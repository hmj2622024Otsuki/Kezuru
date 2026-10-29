using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
	[SerializeField] GameObject HealthTxt;

	public int HP = 500;

	public int getHP() { return HP; } // 

	public void drainHP() { HP -= Random.Range(3, 15); }


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60; // ゲームのフレームレートを指定
	}

	private void Update()
	{
		HealthTxt.GetComponent<TextMeshProUGUI>().text = "HP:" + HP.ToString("F0");
	}
}
