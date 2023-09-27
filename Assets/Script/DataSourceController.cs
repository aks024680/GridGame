using UnityEngine;

namespace Grid
{
    /// <summary>
    /// 資料Grid
    /// </summary>
    public class DataSourceController : MonoBehaviour
    {
        [SerializeField, Header("敵人數值資料"), Range(1, 1000)]
        private int dataNum;

        private void Update()
        {
            OnCalculation();
        }
        public int OnCalculation()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                print("1111111");
                dataNum = Random.Range(0, dataNum);
                return dataNum;
            }
        }
    }
}

