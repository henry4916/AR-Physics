using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;


namespace car_move
{
    public class car_move : MonoBehaviour
    {
        public Animator[] playerGroup;
        private string[] animClipNameGroup;
        private int currentNumber;
        public Rigidbody TB;
        public float speed;
		public Text show_time;
        public GameObject show_win;
        public GameObject show_loss;
        public DateTime startTime;
        int collsion_count;
        // Use this for initialization
        void Start()
        {
            TB = GetComponent<Rigidbody>();
            collsion_count = 0;
            show_win.SetActive(false);
            show_loss.SetActive(false);
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            TB.AddForce(movement * speed);
        }
			
        void Update()
        {
			if (Input.GetKey("up")) { transform.Translate(0, 0, 0.05f);}
            // 按住 上鍵 時，物件每個 frame 朝自身 z 軸方向移動 1 公尺

			if (Input.GetKey("down")) { transform.Translate(0, 0, -0.05f); }
            // 按住 下鍵 時，物件每個 frame 朝自身 z 軸方向移動 -1 公尺

			if (Input.GetKey("left")) { transform.Rotate(0, -0.8f, 0); }
            // 按住 左鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 -3 度

			if (Input.GetKey("right")) { transform.Rotate(0, 0.8f, 0); }
            // 按住 右鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 3 度


        }

		void OnCollisionEnter(Collision other)
		{
			if (other.gameObject.tag == "collision_obj") {
                collsion_count += 1;
                show_time.text = collsion_count.ToString();
            }
            if (other.gameObject.tag == "win")
            {
                show_win.SetActive(true);
            }
            if (collsion_count >= 5)
            {
                show_loss.SetActive(true);
            }
        }


    }
}

