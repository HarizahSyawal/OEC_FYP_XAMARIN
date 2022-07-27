using AIO.IDOS3.Client.Mobile.Models;
using AIO.IDOS3.Client.Mobile.Views;
using AIO.IDOS3.Mobile.Data.SQLiteNet;
using Microsoft.OData.Client;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.ViewModels
{
    public class SignUpPageViewModel : PageViewModelBase<SignUpPageModel>
    {
        #region Constructors
        public SignUpPageViewModel(INavigationService navigationService, Prism.Services.IPageDialogService pageDialogService, IDialogService dialogService)
            : base(navigationService, pageDialogService, dialogService)
        {
            Title = "Sign Up";

            Model.UserNameOptions.IsRequired = true;
            Model.UserNameOptions.Caption = "User Name";

            Model.PasswordOptions.IsRequired = true;
            Model.PasswordOptions.Caption = "Password";

            Model.EmailOptions.IsRequired = true;
            Model.EmailOptions.Caption = "Email";

            PerformLoginCommand = new Command(async () => await OnPerformLogin());
            PerformSignUpCommand = new Command(async () => await OnPerformSignUp());
        }

        #endregion

        #region Properties

        public ICommand PerformLoginCommand { get; }
        public ICommand PerformSignUpCommand { get; }

        #endregion

        #region Methods

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {

            var dbContext = MobileDbContext.Current;

            MobileDbContext.ResetAuthentication();

            base.OnNavigatedTo(parameters);

            await Task.CompletedTask;
        }


        public bool ValidateModel()
        {
            bool isValid = true;
            isValid = (Model.UserNameOptions.Validate(Model.UserName) && isValid);
            isValid = (Model.PasswordOptions.Validate(Model.Password) && isValid);
            isValid = (Model.EmailOptions.Validate(Model.Email) && isValid);

            return isValid;
        }

        protected virtual async Task OnPerformSignUp()
        {
            Model.ResetErrorMessage();

            if (ValidateModel())
            {
                IsBusy = true;
                await Task.Yield();

                _ = Task.Run(async () =>
                {
                    Exception exception = null;

                    var dbContext = MobileDbContext.Current;
                    //mvLogin register = null;
                    var register = new mvLogin();

                    var connection = dbContext.GetConnection();

                    using (connection.Lock())
                    {
                        try
                        {
                            connection.BeginTransaction();

                            var loginTableProvider = dbContext.GetDataTableProvider<mvLoginTableProvider>();
                            var loginServiceProvider = dbContext.DataServiceContext.GetDataServiceProvider<mvLoginServiceProvider>();
                            var loginSyncProvider = dbContext.GetDataSyncProvider<mvLoginSyncProvider>();

                            MobileDbContext.SetAuthentication(Model.UserName, Model.Password);


                            register.Username = Model.UserName;
                            register.Password = Model.Password;

                            //await loginTableProvider.InsertDataAsync(register, true);
                            await loginSyncProvider.UploadDataAsync(register, true);

                            connection.Commit();
                        }
                        catch (Exception ex)
                        {
                            exception = ex;

                            if (exception is DataServiceQueryException)
                            {
                                var dataServiceQueryEx = (DataServiceQueryException)exception;
                                switch (dataServiceQueryEx.Response.StatusCode)
                                {
                                    case 401:
                                        exception = new UnauthorizedAccessException("Invalid User Name or Password");
                                        break;
                                    case 404:
                                        exception = new UnauthorizedAccessException("Could not reach the Server");
                                        break;
                                    default:
                                        break;
                                }
                            }

                            MobileDbContext.ResetAuthentication();
                        }

                        await Device.InvokeOnMainThreadAsync(async () =>
                        {
                            if (exception == null)
                            {
                                var navigationParams = new NavigationParameters();

                                navigationParams.Add("User", null);

                                await NavigationService.NavigateAsync(nameof(LoginPage), navigationParams);
                                //}
                            }
                            else
                                Model.SetErrorMessage(exception.Message);

                            IsBusy = false;

                            await Task.Yield();

                        });
                    }
                });
            }
        }


        protected virtual async Task OnPerformLogin()
        {
            await NavigationService.NavigateAsync(nameof(LoginPage), new NavigationParameters(), false, true);
        }

        #endregion
    }
}