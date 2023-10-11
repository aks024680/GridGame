using UnityEngine;
using UnityEngine.UI;

namespace Grid
{
    /// <summary>
    /// 清除敵人
    /// </summary>
    public class ChangeEnemy : MonoBehaviour
    {
        Button btn;
        public void OnClick()
        {
            gameObject.SetActive(false);
        }
        public void OnClick2()
        {
            gameObject.SetActive(false);
        }
        public void OnClick3()
        {
            gameObject.SetActive(false);
        }
    }
}