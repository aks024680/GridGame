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

        public bool valueBool;

        public Text enemyText,playerText;

        private void Start()
        {
            valueBool = true;
            EnemyValue(stoneDataNum);
        }
        
        private void Update()
        {
            PlayerValue(changeDataNum);

        }
        public void PlayerValue(int value)
        {
            if (valueBool)
            {
                print("1111111");
                value = changeDataNum;
                playerText.text = changeDataNum.ToString();
            }
        }
        public void EnemyValue(int enemyValue)
        {
            print("44444");
            enemyValue = stoneDataNum;
            enemyText.text = stoneDataNum.ToString();
        }
    }
}

