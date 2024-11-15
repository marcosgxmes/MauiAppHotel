namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto? QuartoSelecionado {  get; set; }
        public int QntAdultos { get; set; }
        public int QtdCriancas { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
         public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double Valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double Valor_criancas = QtdCriancas * QuartoSelecionado.ValorDiariaCriaca;

                double total = (Valor_adultos + Valor_criancas) * Estadia;

                return total;
            }
        }

    }
}
