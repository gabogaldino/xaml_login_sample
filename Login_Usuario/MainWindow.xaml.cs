using System.Linq;
using System.Windows;
using Login_Usuario.Data;

namespace Login_Usuario;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // Obter o nome de usuário e senha do usuário
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Verificar se o nome de usuário e senha estão corretos
        if (username == "admin" && password == "123456")
        {
            // Se estiverem corretos, exibir uma mensagem de sucesso
            MessageBox.Show("Login realizado com sucesso!");
        }
        else
        {
            // Se estiverem incorretos, exibir uma mensagem de erro
            MessageBox.Show("Nome de usuário ou senha incorretos. Por favor, tente novamente.");
        }
        //private readonly Context context;
        //Usuario newProduct = new();


        //private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        //{

        //}
    }
}