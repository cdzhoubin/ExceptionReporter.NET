using System;
using System.Collections.Generic;

namespace ExceptionReporter
{
    /// <summary>
    /// The interface (contract) for an ExceptionReportView
    /// </summary>
    public interface IExceptionReportView
    {
        string ProgressMessage { set; }
        bool EnableEmailButton { set; }
        bool ShowProgressBar { set; }
        bool ShowFullDetail { get; set; }
    	string UserExplanation { get; }
        void ShowErrorDialog(string message, Exception exception);
        void SetEmailCompletedState(bool success);
        void SetEmailCompletedState_WithMessageIfSuccess(bool success, string successMessage);
    	void SetInProgressState();
        void PopulateConfigTab(string filePath);
        void PopulateExceptionTab(IList<Exception> exceptions);
        void PopulateAssembliesTab();
        void PopulateSysInfoTab();
    	void SetProgressCompleteState();
        void ToggleShowFullDetail();
    }
}