﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteDrive.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public string PrecoFormatado 
        {
            get { return $"R$ {Preco}"; } 
        }

    }
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome= "Azera V6", Preco=60000},
                new Veiculo {Nome="Fiesta 2.0", Preco=50000},
                new Veiculo {Nome= "HB20 S", Preco=40000}
            };

            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //DisplayAlert("Test Drive", $"Você selecionou o carro {veiculo.Nome}, que custa {veiculo.Preco}", "OK");

            Navigation.PushAsync(new DetalheView());
        }
    }
}