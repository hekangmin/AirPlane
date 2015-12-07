// Author:
// [LongTianhong]
//
// Copyright (C) 2014 Nanjing Xiaoxi Network Technology Co., Ltd. (http://www.mogoomobile.com)

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Game {


	public class Move : MonoBehaviour {

		public Vector3 Speed;

		void Update() {
			transform.Translate(Speed * Time.deltaTime);
		}
	}
}
