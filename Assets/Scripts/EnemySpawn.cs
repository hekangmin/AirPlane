// Author:
// [LongTianhong]
//
// Copyright (C) 2014 Nanjing Xiaoxi Network Technology Co., Ltd. (http://www.mogoomobile.com)

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Game{

	public class EnemySpawn : MonoBehaviour{
		/// <summary>
		/// 敌人预制件
		/// </summary>
		public GameObject EnemyPrefab;
		/// <summary>
		/// 随机生成的范围
		/// </summary>
		public float RandomRange = 10f;

		/// <summary>
		/// 生成间隔
		/// </summary>
		public float Interval = 3f;


		private float _timer = 0f;

		void Update(){
			_timer += Time.deltaTime;
			if (_timer >= Interval){
				_timer = 0f;
				var pos = transform.position;
				pos.x += Random.Range(0f, RandomRange);
                Instantiate(EnemyPrefab, pos, Quaternion.Euler(0f, 0f, 180f));
			}
		}

	}
}