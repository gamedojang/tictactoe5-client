using TMPro;
using UnityEngine;

public class SigninPanelController : PanelController
{
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private TMP_InputField passwordInputField;
    
    public void Show()
    {
        base.Show();
    }
    
    public void OnClickConfirmButton()
    {
        Hide(() =>
        {
            // TODO: 로그인 기능 구현
            
            
            
        });
    }
}
