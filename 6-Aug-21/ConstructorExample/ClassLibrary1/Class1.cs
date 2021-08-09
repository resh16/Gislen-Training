using System;
public class SalaryAccount
{
    public string AccountId;
    public string Name;
    public int Balance;
    
}

public class SalaryOrDemantAccount:SalaryAccount
{
    public string PanCardNumber;


    

    public SalaryOrDemantAccount(string accountId, string name, int balance, string panCardNumber="")
    {
        this.AccountId = accountId;
        this.Name = name;
        this.Balance = balance;
        this.PanCardNumber = panCardNumber;
        if(panCardNumber == "")
        {
            Console.WriteLine("SalaryAccount Created by : " + Name);
        }
        Console.WriteLine("Salary and Demant Account Created by : " + Name);
    }
}