using UnityEngine;

namespace Grid
{
/// <summary>
/// 比大小控制器
/// </summary>
    public class CompareBigOrSmall : MonoBehaviour
    {

        public DataSourceController data;
        private void Start()
        {
            data = GetComponent<DataSourceController>();
        }
        private void Update()
        {
            CompareValue();
        }
        private void CompareValue()
        {
            if(data.changeDataNum > data.stoneDataNum)
            {
                data.changeDataNum += data.stoneDataNum;
                
            }
            else
            {
                print("GameOver");
            }
        }
    }
}

