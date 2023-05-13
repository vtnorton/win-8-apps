﻿using DouaiCore;
using DouaiCore.Classes;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiWPFull.Views
{
    public sealed partial class Conjugado : Page
    {
        private static string verboRecebido;
        public Conjugado()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            verboRecebido = (string)e.Parameter;
            ConjulgarVerbo(verboRecebido.ToLower().Trim());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConjulgarVerbo(txtVerbo.Text.ToLower().Trim());
        }
        private async void ConjulgarVerbo(string xverbo)
        {
            if (!Check.EhVerbo(xverbo))
            {
                await new MessageDialog("O que você está tentando conjugar não é um verbo, tente novamente!", "Não é um verbo").ShowAsync();
            }
            else
            {
                Verbo verboConjugado = Conjugar.Conjugador(xverbo);
                lblPresente.Text = verboConjugado.Presente;
                lblFuturoDoPresente.Text = verboConjugado.FuturoDoPresente;
                lblFuturoDoPreterito.Text = verboConjugado.FuturoDoPreterito;
                lblFuturoDoSubjuntivo.Text = verboConjugado.FuturoDoSubjuntivo;
                lblImperativo.Text = verboConjugado.ImperativoAfirmativo;
                lblImperativoNegativo.Text = verboConjugado.ImperativoNegativo;
                lblPresenteDoSubjuntivo.Text = verboConjugado.PresenteDoSubjuntivo;
                lblPreteritoImperfeito.Text = verboConjugado.PreteritoImperfeito;
                lblPreteritoImperfeitoDoSubjuntivo.Text = verboConjugado.PreteritoImperfeitoDoSubjuntivo;
                lblPreteritoMaisQuePerfeito.Text = verboConjugado.PreteritoMaisQuePerfeito;
                lblPreteritoPerfeito.Text = verboConjugado.PreteritoPerfeito;
                lblPrincipal.Text = verboConjugado.Principal;
                lblInfinitivo.Text = verboConjugado.InfinitivoPessoal;
            }
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
