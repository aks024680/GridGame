﻿using UnityEngine;
using UnityEngine.UI;


namespace Grid
{
    /// <summary>
    /// 資料Grid
    /// </summary>
    public class DataSourceController : MonoBehaviour
    {
        [SerializeField, Header("變動數值資料"), Range(1, 1000)]
        public int changeDataNum;
        [SerializeField, Header("固定數值資料"), Range(1, 1000)]
        public int stoneDataNum;
        

        ChangeEnemy enemy;

        int minVal = 1;
        int maxVal = 10000;

        public Button FirstEnemyBtn;
        public Button SecondEnemyBtn;
        public Button ThirdEnemyBtn;


        private int akan = 1;
        public Text enemyText,playerText;

        private void Start()
        {
            EnemyValue(stoneDataNum);
           enemy = GetComponentInChildren<ChangeEnemy>();
        }

        public void OnMouseDown()
        {
            print(changeDataNum);

            CompareValue();
            PlayerValue(changeDataNum);
            
            print("hahahahahahahahahahahahahahahahahahahhahah");
            //myImage.sprite = Resources.Load("Image/Enemy/aphid", typeof(Sprite)) as Sprite;
        }
        public void PlayerValue(int value)
        {
            while (akan > 0)
            { 
                value = changeDataNum;
                changeDataNum = Mathf.Clamp(value, minVal, maxVal);
                playerText.text = changeDataNum.ToString();
                CompareValue();
                akan--;
            }
        }
        public void EnemyValue(int enemyValue)
        {
            enemyValue = stoneDataNum;
            enemyText.text = stoneDataNum.ToString();
        }
        public bool CompareValue()
        {
            if (changeDataNum > stoneDataNum)
            {
                changeDataNum += stoneDataNum;

                print("123");

                return true;
                
            }
            else
            {
                print("GameOver");
                return false;
            }
        }
        /*public void OnClick()
        {
            
            FirstEnemyBtn.gameObject.SetActive(false);
        }
        public void OnClick2()
        {
            
            SecondEnemyBtn.gameObject.SetActive(false);
        }
        public void OnClick3()
        {
            
            ThirdEnemyBtn.gameObject.SetActive(false);
        }*/
    }
}
