using UnityEngine;
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

        int minVal,maxVal = 10000;

        public bool valueBoo1;
        private int akan = 2;
        public Text enemyText,playerText;

        private void Start()
        {
            valueBoo1 = true;
            EnemyValue(stoneDataNum);
        }
        
        private void Update()
        {
            PlayerValue(changeDataNum);

        }
        public void PlayerValue(int value)
        {
            while (akan>0)
            {
                print("222222");
                value = changeDataNum;
                changeDataNum = Mathf.Clamp(value, minVal, maxVal);
                playerText.text = changeDataNum.ToString();
                if (CompareValue())
                {
                    akan--;
                }
                else
                {
                    print("GG");
                }
            }
        }
        public void EnemyValue(int enemyValue)
        {
            print("44444");
            enemyValue = stoneDataNum;
            enemyText.text = stoneDataNum.ToString();
        }
        private bool CompareValue()
        {
            if (changeDataNum > stoneDataNum)
            {
                changeDataNum += stoneDataNum;
                return true;

            }
            else
            {
                print("GameOver");
                return false;
            }
        }
    }
}
