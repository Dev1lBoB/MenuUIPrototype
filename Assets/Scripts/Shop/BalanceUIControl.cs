using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceUIControl : MonoBehaviour
{
    public Balance  userBalance;
    public Text     moneyText;
    public Text     brainsText;
    public Text     crystalsText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = userBalance.getResource("Money").ToString();
        brainsText.text = userBalance.getResource("Brain").ToString();
        crystalsText.text = userBalance.getResource("Crystal").ToString();
    }

    public void UpdateInfo()
    {
        // Update the information about resources into the UI
        moneyText.text = userBalance.getResource("Money").ToString();
        brainsText.text = userBalance.getResource("Brain").ToString();
        crystalsText.text = userBalance.getResource("Crystal").ToString();
    }
}
