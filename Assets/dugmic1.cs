using UnityEngine;
using UnityEngine.SceneManagement;
public class dugmic1 : MonoBehaviour
{
    [SerializeFeild] private string Scena1 = "SampleScene";
    public void NewGameButton()
    {
        SceneManager.LoadScene(Scena1);
    }
}
