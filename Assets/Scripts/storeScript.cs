using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeScript : MonoBehaviour
{

    public static int cargo = 0;


    public Text textObj;
    public Text textObj2;

    // Use this for initialization
    void Start()
    {
        int oldcargo = PlayerPrefs.GetInt("cargo", 0);
        cargo = oldcargo;
    }

    // Update is called once per frame
    void Update()
    {
        var textComp = textObj.GetComponent<Text>();
        var textComp2 = textObj2.GetComponent<Text>();
        cargo = PlayerController.cargo;

        textComp.text = cargo.ToString() + "/60";
        textComp2.text = "CANNONS: " + ((PlayerController.cannonGroups * 4) * 2).ToString();
    }

    public void buyGoodBrick()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoBrick++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodLumber()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoLumber++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void buyGoodLivestock()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoLivestock++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodGrain()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoGrain++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodOre()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoOre++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodCoin()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoCoin++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodCloth()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoCloth++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyGoodBooks()
    {
        if (PlayerController.gold >= 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoBooks++;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void buyBadBrick()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoBrick++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadLumber()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoLumber++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void buyBadLivestock()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoLivestock++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadGrain()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoGrain++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadOre()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoOre++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadCoin()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoCoin++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadCloth()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoCloth++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void buyBadBooks()
    {
        if (PlayerController.gold > 1 && PlayerController.cargo < 60)
        {
            PlayerController.cargo++;
            PlayerController.cargoBooks++;
            PlayerController.gold--;
            PlayerController.gold--;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }






    public void sellGoodBrick()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoBrick--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodLumber()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoLumber--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void sellGoodLivestock()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoLivestock--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodGrain()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoGrain--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodOre()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoOre--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodCoin()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoCoin--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodCloth()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoCloth--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellGoodBooks()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoBooks--;
            PlayerController.gold++;
            PlayerController.gold++;

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void sellBadBrick()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoBrick--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadLumber()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoLumber--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }

    public void sellBadLivestock()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoLivestock--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadGrain()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoGrain--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadOre()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoOre--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadCoin()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoCoin--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadCloth()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoCloth--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }
    public void sellBadBooks()
    {
        if (PlayerController.cargo > 0)
        {
            PlayerController.cargo--;
            PlayerController.cargoBooks--;
            PlayerController.gold++;
            

            PlayerPrefs.SetInt("score", PlayerController.gold);
            PlayerPrefs.SetInt("cargo", PlayerController.cargo);
        }
    }


    public void upgrade()
    {
        if (PlayerController.gold >= (1000 * PlayerController.cannonGroups))
        {
            PlayerController.gold = (-1000 * PlayerController.cannonGroups);
            PlayerController.cannonGroups++;
            PlayerController.cannonGroups++;
            PlayerController.cannonGroups++;
            PlayerController.cannonGroups++;




        }
    }




    public void StoreCargo(int newcargo)
    {
        PlayerPrefs.SetInt("cargo", newcargo);
    }
}
