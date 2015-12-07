using UnityEngine;
using System.Collections;


namespace Game {


	public class PlayerController : MonoBehaviour {

		/// <summary>
		/// 移动速度
		/// </summary>
		public float Speed;
		/// <summary>
		/// 子弹预制
		/// </summary>
		public GameObject BulletPrefab;

		public float LerpDelta = 1;

		void Start() {
			StartCoroutine(Shoot());//开启一个协程，自动发射子弹
		}

		IEnumerator Shoot() {
			while (true) {
				yield return new WaitForSeconds(0.2f);
				Instantiate(BulletPrefab, transform.position, Quaternion.identity);
			}
		}

		// Update is called once per frame
		void Update() {
			var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			targetPos.z = 0f;
			transform.position = Vector3.MoveTowards(transform.position, targetPos, LerpDelta * Time.deltaTime);


		}
	}
}
