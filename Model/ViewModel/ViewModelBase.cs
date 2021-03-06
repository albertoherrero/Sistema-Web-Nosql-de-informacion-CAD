﻿using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

public class ViewModelBase
{
    #region Variables and Properties


    public string PageTitle;

    protected HttpSessionState currentSession
    {
        get
        {
            return HttpContext.Current.Session;
        }
    }


    private const string WebProcessContactEmail = "ContactEmail";
    public string ProcessContactEmail
    {
        get
        {
            return currentSession[WebProcessContactEmail].ToString();
        }
        set
        {
            currentSession[WebProcessContactEmail] = value;
        }
    }

    private const string WebProcessContactName = "ContactName";
    public string ProcessContactName
    {
        get
        {
            return currentSession[WebProcessContactName].ToString();
        }
        set
        {
            currentSession[WebProcessContactName] = value;
        }
    }

    private const string WebProcessContactSubject = "ProcessContactSubject";
    public string ProccessContactMailSubject
    {
        get
        {
            return currentSession[WebProcessContactSubject].ToString();
        }
        set
        {
            currentSession[WebProcessContactSubject] = value;
        }
    }

    private const string WebLastExecutionPlanName = "LastExecutionPlanName";
    public string LastExecutionPlanName
    {
        get
        {
            return currentSession[WebLastExecutionPlanName]?.ToString();
        }
        set
        {
            currentSession[WebLastExecutionPlanName] = value;
        }
    }

    private const string WebLastExecutionPlanText = "LastExecutionPlanText";
    public string LastExecutionPlanText
    {
        get
        {
            return currentSession[WebLastExecutionPlanText]?.ToString();
        }
        set
        {
            currentSession[WebLastExecutionPlanText] = value;
        }
    }
    public bool IsCallback { get; set; }

    #endregion

}