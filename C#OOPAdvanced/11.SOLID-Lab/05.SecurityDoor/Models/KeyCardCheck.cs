﻿public class KeyCardCheck : SecurityCheck
{
    private ISecurityUI securityUI;

    public KeyCardCheck(ISecurityUI securityUI)
    {
        this.securityUI = securityUI;
    }

    public bool IsValid(string code)
    {
        return true;
    }

    public override bool ValidateUser()
    {
        string code = securityUI.RequestKeyCard();

        if (IsValid(code))
        {
            return true;
        }

        return false;
    }
}