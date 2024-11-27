using MauiAppEventoPrograma.Models;
using MauiAppEventoPrograma.Telas;

namespace MauiAppEventoPrograma.Telas;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();

        evento_inicio.MinimumDate = DateTime.Now;
        evento_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        evento_termino.MinimumDate = evento_termino.Date.AddDays(2);
        evento_termino.MaximumDate = evento_inicio.MaximumDate.AddMonths(1);
        

    }



    private async void Button_Clicked(object sender, EventArgs e)
    {


        try
        {

            Evento evento = new Evento
            {


                Nome = Convert.ToString(evento_nome.Text),
                DataInicio = evento_inicio.Date,
                DataTermino = evento_termino.Date,
                Participantes = Convert.ToInt32(evento_participantes.Text),
                CustoParticipante = Convert.ToDouble(evento_preco.Text),
                Local = Convert.ToString(evento_local.Text),



            };

            await Navigation.PushModalAsync(new DetalheEvento() { BindingContext = evento });

        }
        catch (Exception ex)
        {

            await DisplayAlert("Algo deu errado", ex.Message, "ok");


        }

        

    }

    private void EventoInicioDateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker? Elemento = sender as DatePicker;

        DateTime data_selecionada = Elemento.Date;

        evento_termino.MinimumDate = data_selecionada.AddDays(1);
        evento_termino.MaximumDate = data_selecionada.AddMonths(1);
    }
}


