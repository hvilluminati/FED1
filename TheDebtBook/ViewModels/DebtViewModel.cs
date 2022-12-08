using TheDebtBook.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace TheDebtBook.ViewModels
{
    public class DebtViewModel : BindableBase
    {
        public DebtViewModel(string title, Debtor debtor)
        {
            Title = title;
            CurrentDebtor = debtor;
        }

        #region Properties
        string title;

        public string Title
        {
            get { return title; }
            set
            {
                SetProperty(ref title, value);
            }
        }
        Debtor currentDebtor;

        public Debtor CurrentDebtor
        {
            get { return currentDebtor; }
            set
            {
                SetProperty(ref currentDebtor, value);
            }
        }

        //bool isValid;

        public bool IsValid
        {
            get
            {
                bool isValid = true;
                if (string.IsNullOrWhiteSpace(CurrentDebtor.Name))
                    isValid = false;
                return isValid;
            }
            //set
            //{
            //    SetProperty(ref isValid, value);
            //}
        }

        #endregion

        #region Commands

        ICommand _okBtnCommand;
        public ICommand OkBtnCommand
        {
            get
            {
                return _okBtnCommand ?? (_okBtnCommand = new DelegateCommand(
                    OkBtnCommand_Execute, OkBtnCommand_CanExecute)
                  .ObservesProperty(() => CurrentDebtor.Name));
                  //.ObservesProperty(() => CurrentDebtor.Debt));
            }
        }

        private void OkBtnCommand_Execute()
        {
            // No action here - is handled i code behind
        }

        private bool OkBtnCommand_CanExecute()
        {
            return IsValid;
        }

        #endregion
    }
}
