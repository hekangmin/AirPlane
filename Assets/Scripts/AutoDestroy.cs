// Author:
// [LongTianhong]
//
// Copyright (C) 2014 Nanjing Xiaoxi Network Technology Co., Ltd. (http://www.mogoomobile.com)

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Game {

	public class AutoDestroy : MonoBehaviour {


		public float time;

		private float _timer;

		void Update() {
			_timer += Time.deltaTime;//计时
			if (_timer >= time) {//时间到了之后自动销毁自己
				Destroy(gameObject);
			}

		}
	}
}