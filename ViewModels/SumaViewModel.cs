using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace SumaBinding.ViewModels;

public class SumaViewModel : INotifyPropertyChanged
{
    private string numero1 = "";
    private string numero2 = "";
    private string resultado = "Resultado pendiente";

    public string Numero1
    {
        get => numero1;
        set { numero1 = value; OnPropertyChanged(); }
    }

    public string Numero2
    {
        get => numero2;
        set { numero2 = value; OnPropertyChanged(); }
    }

    public string Resultado
    {
        get => resultado;
        set { resultado = value; OnPropertyChanged(); }
    }

    public ICommand SumarCommand { get; }

    public SumaViewModel()
    {
        SumarCommand = new Command(Sumar);
    }

    private void Sumar()
    {
        double numeroUno = Convert.ToDouble(Numero1);
        double numeroDos = Convert.ToDouble(Numero2);
        double suma = numeroUno + numeroDos;
        Resultado = "Resultado: " + suma;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? nombre = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}
