using System.Windows.Input;

namespace IdoApp.Views;

public partial class SignUpPage : ContentPage
{
    private string? _firstName;
    private string? _lastName;
    private string? _email;
    private string? _password;
    private string? _mobile;
    private bool _entryAsPassword;
    private string? _passwordIconCode;

    public ICommand? ShowPasswordCommand { get; }
    public ICommand? SignInCommand { get; }

    public SignUpPage()
    {
        InitializeComponent();
        BindingContext = this;

        _entryAsPassword = true;
        _passwordIconCode = FontHelper.CLOSED_EYE_ICON;

        ShowPasswordCommand = new Command(TogglePasswordButton);
        SignInCommand = new Command(SignUp, Validate);
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (_firstName != value)
{
                _firstName = value;
                OnPropertyChanged();
            }
        }
    }
    public string LastName { ...}
    public string UserEmail { ...}
    public string UserPassword { ...}
    public string Mobile { ...}
    public bool EntryAsPassword { ...}
    public string PasswordIconCode { ...}


    private void TogglePasswordButton()
    {
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        if (EntryAsPassword)
            PasswordIconCode = FontHelper.CLOSED_EYE_ICON;
        else
            PasswordIconCode = FontHelper.OPEN_EYE_ICON;

    }
    private void SignUp()
    {
        //Register user into DB
        //Save User to Current User
        //Go to Main Page
    }
    private bool Validate()
    {
        return true;
    }
}