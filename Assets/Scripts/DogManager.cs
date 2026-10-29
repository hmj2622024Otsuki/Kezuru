using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DogManager : MonoBehaviour
{
	[SerializeField] AudioClip damageSE;
	Animator animator;
	bool dead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		// 犬のアニメーションを再生できるようにする
		animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
		
    }

	private async void OnTriggerEnter(Collider collision)
	{
		if (collision.CompareTag("Prop"))
		{
			if (FindObjectOfType<GameManager>().getHP() <= 0)
			{
				if (dead == true)
				{
					
				}
				else 
				{
					dead = true; // 重複回避
					animator.SetBool("isDie", true);
					AudioSource.PlayClipAtPoint(damageSE, transform.position);
					await Task.Delay(5000); // 5000ミリ秒(５秒待つ)
					SceneManager.LoadScene("GameScene"); // シーン遷移
				}
			}

			animator.SetTrigger("isDamage");
			FindObjectOfType<GameManager>().drainHP();
			AudioSource.PlayClipAtPoint(damageSE, transform.position);
		}
	}
}
