namespace variable; 

public partial class MainPage : ContentPage
{
    int contador = 0;
    const double PI = 3.1416;
    readonly string name = "Variables Locales";

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnIncrementarClicked(object? sender, EventArgs e)
    {
        contador++;
        lblcontador.Text = contador.ToString();
    }

    private void OnMostrarVariableClicked(object? sender, EventArgs e)
    {
        int edad = 20;
        string nombre = "Alejandro M. Tineo";
        string profe = "Juancito";

        lblresultado.Text = $"{name}\n" +
                            $"PI: {PI}\n" +
                            $"Usuario: {nombre}\n" +
                            $"Edad: {edad}\n" +
                            $"Profesor: {profe}";
    }
}