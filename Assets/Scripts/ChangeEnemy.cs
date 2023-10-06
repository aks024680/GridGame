using UnityEngine;
using UnityEngine.UI;

namespace Grid
{
    /// <summary>
    /// 清除敵人
    /// </summary>
    public class ChangeEnemy : MonoBehaviour
    {
        public void OnClick()
        {
            this.gameObject.SetActive(false);
        }
    }
}