using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    private int amountOfBrains;
    private int amountOfCrystals;
    private int amountOfMoney;

    //
    // Uncomment to set up the starting values of resources and not the saved ones
    //
    // void Start()
    // {
    //     amountOfBrains = 0;
    //     amountOfCrystals = 0;
    //     amountOfMoney = 100;
    // }

    public void spendResource(int amount, string type)
    {
        if (type == "Brain")
            spendBrains(amount);
        else if (type == "Crystal")
            spendCrystals(amount);
        else if (type == "Money")
            spendMoney(amount);
        else
            throw new Exception();
    }

    public void earnResource(int amount, string type)
    {
        if (type == "Brain")
            earnBrains(amount);
        else if (type == "Crystal")
            earnCrystals(amount);
        else if (type == "Money")
            earnMoney(amount);
        else
            throw new Exception();
    }

    public int getResource(string type)
    {
        if (type == "Brain")
            return amountOfBrains;
        else if (type == "Crystal")
            return amountOfCrystals;
        else if (type == "Money")
            return amountOfMoney;
        else
            throw new Exception();
    }

    private void spendMoney(int amount)
    {
        if (amount > amountOfMoney)
            throw new Exception();
        else
            amountOfMoney -= amount;
    }

    private void earnMoney(int amount)
    {
        amountOfMoney += amount;
    }

    private void spendBrains(int amount)
    {
        if (amount > amountOfBrains)
            throw new Exception();
        else
            amountOfBrains -= amount;
    }
    
    private void earnBrains(int amount)
    {
        amountOfBrains += amount;
    }

    private void spendCrystals(int amount)
    {
        if (amount > amountOfCrystals)
            throw new Exception();
        else
            amountOfCrystals -= amount;
    }
    
    private void earnCrystals(int amount)
    {
        amountOfCrystals += amount;
    }
}
