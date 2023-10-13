
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Grid
{
    public class SaveData : MonoBehaviour
    {
        public Text firstText;
        public Text secondText;
        public Text thirdText;

        public Button FirstEnemyBtn;
        public Button SecondEnemyBtn;
        public Button ThirdEnemyBtn;
        
         
        public int bigger, smaller;

        DataSourceController dataSourceController;
        private void Awake()
        {
            ClickFirstButton();
            dataSourceController = GetComponent<DataSourceController>();
        }
       
        public void ScoreCompare()
        {
            FirstEnemyBtn.onClick.AddListener(ClickFirstButton);
        }
        public void ClickFirstButton()
        {
            if (dataSourceController.CompareValue(bigger,smaller)) 
            { 
                print("1234");
                FirstEnemyBtn.gameObject.SetActive(false);
            }
        }
    }

}

