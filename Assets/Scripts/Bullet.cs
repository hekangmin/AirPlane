// Author:
// [LongTianhong]
//
// Copyright (C) 2014 Nanjing Xiaoxi Network Technology Co., Ltd. (http://www.mogoomobile.com)

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Game {

	public class Bullet : MonoBehaviour {

		/// <summary>
		/// 爆炸特效
		/// </summary>
		public GameObject ExplosionEffect;


		void OnTriggerEnter(Collider other) {
			if (other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Enemy")) {//如果碰撞到敌人，则播放特效，并销毁自己和敌人
				Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
				Destroy(other.attachedRigidbody.gameObject);
				Destroy(gameObject);
			}
		}

	}
}