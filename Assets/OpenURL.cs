using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{

    public void X()
    {
        Application.OpenURL("https://twitter.com/ADA_TWQ?ref_src=twsrc%5Etfw%7Ctwcamp%5Etweetembed%7Ctwterm%5E1659571275621072898%7Ctwgr%5E9facfc916120340e05b76d3775600aea9326e8e4%7Ctwcon%5Es1_&ref_url=https%3A%2F%2Fdeveloperacademy.tuwaiq.edu.sa%2F");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/company/adatwq/?originalSubdomain=sa");
    }


    public void Weibsite()
    {
        Application.OpenURL("https://developeracademy.tuwaiq.edu.sa/#home-section");
    }
}
