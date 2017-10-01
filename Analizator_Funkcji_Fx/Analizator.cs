using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Analizator_Funkcji_Fx
{
    public partial class Analizator : Form
    {
        public Analizator()
        {
            InitializeComponent();
        }

        // deklaracja zmienych globalnych
        // deklaracja zmienej d przechowywania wyliczonej waytości F(x)
        double PB_Wyliczone_Y;

        // wywołanie metody sprawdzania wprowadzania danych 
        // i sprawdzania przedziału określoności dla zadeklarowanego PB_X
        bool PB_OkresleniePrzedzialuFunkcjiFX(out double PB_X, out double PB_Xd, out double PB_Xg, out double PB_h)
        {
            // ustawienie domyślnej wartości dla zmiennej PB_X
            // gdy zapalamy kontrolkę errorProvider1

            PB_X = 0.0F;
            PB_Xd = 0.0F;
            PB_Xg = 0.0F;
            PB_h = 0.0F;

            // pobieranie wartości zmiennej PB_X
            // sprawdzenie, czy została wpisana wartość zmiennej PB_X

            if (string.IsNullOrEmpty(PB_WartoscZmienejX.Text))
            {
                // "zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                errorProvider1.SetError(PB_WartoscZmienejX,
                    "ERROR: musisz podać wartość zmiennej X");
                return false;
                // zakończenie sprawdzania czy wpisano cokolwiek jako zadeklarowaną wartość PB_X
            }

            // wczytanie wartości zmiennej PB_X ze sprawdzeniem poprawności zapisu 

            errorProvider1.Dispose();
            if (!double.TryParse(PB_WartoscZmienejX.Text, out PB_X))
            {
                errorProvider1.SetError(PB_WartoscZmienejX,
                    "ERROR: wystąpił niedozwolony znak w zapisie"
                    + "wartości zmiennej X");
                return false;
                // zakończenie sprawdzania poprawności wpisania wartości PB_X
            }

            // sprawdzenie przedziału określoności zmiennej X: PB_X <> 0
            errorProvider1.Dispose();

            // srawdzenie czy zadeklarowana artość PB_x jest różna od (0)
            // ponieważ w przypadku cyfry (0) jedyny przedział w którym się ta cyfra znajduje 
            // automatycznie jest zerowany, i wykres staje się wykresem punktu zerowego układu spółrzędnych
            if (PB_X == 0.0F)
            {
                errorProvider1.SetError(PB_WartoscZmienejX,
                    "ERROR: (X = 0) zeruje wynik funkcji F(x) w swoim przedziale, "
                    + "(podaj inną wartość X");
                return false;
                // zakończenie sprawdzania czy zadeklarowana zmiena PB_x jest różna od (0)
            }

            // sprawdzenie przedziału określoności zmiennej X: PB_X < -1
            errorProvider1.Dispose();

            if (PB_X < -1.0F)
            {
                PB_dgpxd.Text = "X należy do przedziału (X < -1), "
                + "Zdefiniuj dolną granicę dla funkcji F(x)";
                PB_ggpfg.Text = "X należy do przedziału (X < -1), "
                + "Zdefiniuj Górną granicę dla funkcji F(x)";

                //sprawdzenie czy do kontrolki PB_DolnaGranicaPrzedzialuFD 
                // wprowadzono dane
                if (String.IsNullOrEmpty(PB_DolnaGranicaPrzedzialuFD.Text))
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                    errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                "ERROR: musisz podać dolną wartość przedziału Xd");
                    return false;
                    // zakończenie sprawdzania czy wpisano cokolwiek 
                    // do kontrolki PB_DolnaGranicaPrzedzialuFD 
                }

                // wczytanie wartości zmiennej Xd ze sprawdzeniem poprawności zapisu 
                if (!double.TryParse(PB_DolnaGranicaPrzedzialuFD.Text, out PB_Xd))
                {
                    errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                        "ERROR: wystąpił niedozwolony znak w zapisie"
                        + "wartości zmiennej Xd");
                    return false;
                    // zakończenie sprawdzania poprawności danych wprowadzonych 
                    // w kontrolce PB_DolnaGranicaPrzedzialuFD 
                }

                // sprawdzenie czy wprowadzona wartość mieści się w zakresie
                //określoności funkcji F(x) dla wprowadzonego parametru PB_Xd
                if (PB_Xd >= -1.0F)
                {
                    errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                        "ERROR: Dla wprowadzonej wartości X, wartość minimalna musi spełniać równanie (Fd < -1) ");
                    return false;
                    // zakończenie realizacji sprawdzenia czy PB_Xd mieści się w zakresie określoności 
                }

                // sprawdzenie czy wpisano coś do kontrolki dolnej granicy Xg
                if (String.IsNullOrEmpty(PB_GornaGranicaPrazedzialuFG.Text))
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                    errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                "ERROR: musisz podać górną wartość przedziału Xg");
                    return false;
                    // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_GornaGranicaPrazedzialuFG
                }

                // wczytanie danych i sprawdzenie poproawności formatu w kotrolce PB_GornaGranicaPrazedzialuFG
                if (!double.TryParse(PB_GornaGranicaPrazedzialuFG.Text, out PB_Xg))
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                    errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                    "ERROR: urzyto niedozwolonych znaków w zapisie parametru Xg");
                    return false;
                    // zakończenie sprawdzania poprawności danych wpisanych
                    // do kontrolki PB_GornaGranicaPrazedzialuFG
                }

                // sprawdzenie czy wprowadzona wartość mieści się w zakresie
                //określoności funkcji F(x) dla wprowadzonego parametru PB_Xg
                if (PB_Xg >= -1.0F)
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                    errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                        "ERROR: Dla wprowadzonej wartości X, wartość maksymalna musi spełniać równanie (Fg < -1) ");
                    return false;
                    // zakończenie realizacji sprawdzenia czy PB_Fg mieści się w zakresie określoności 
                }

                // sprawdzenie czy wprowadzona wartość maksymalna Xg ie jest mniejsza od Xd
                if (PB_Xd > PB_Xg)
                {
                    errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                    "ERROR: Wartość maksymalna Xg nie może być mniejsza od minimalnej Xd ");
                    return false;
                    // zakończenie realizacji sprawdzenia czy Xg nie jest mniejsza od PB_Xd
                }

                // sprawdzenie poprawności wprowadzenia danych do kontrolki h
                if (String.IsNullOrEmpty(PB_KrokPrzyrostuHFX.Text))
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                    errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                "ERROR: msisz podać wartośc ktroku przeliczeniowego h");
                    return false;
                    // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_KrokPrzyrostuHFX
                }

                // wczytanie danych i sprawdzenie poprawności formatu danych w kontrolce PB_h
                if (!double.TryParse(PB_KrokPrzyrostuHFX.Text, out PB_h))
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                    errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                "ERROR: użyto nieprawidłowego znaku. Wprowadźpoprawnie wartość kroku h");
                    return true;
                    // zakonczenie sprawdzania czy poproawnie wprowadzono wartość kroku h
                }

                // sprawdzenie, czy wartośc kroku H nie jest mniejsza od 0
                if (PB_h <= 0.0F)
                {
                    // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                    errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                "ERROR: wartośc kroku przyrostu obliczeń nie może być równy, mniejszy niż (0)");
                    return true;
                    // zakonczenie sprawdzania czy wartość kroku h nie jest równa lub mniejsza od 0
                }
                // zgaszenie kontrolki errorProvider1
                errorProvider1.Dispose();
            }
            else
                // sprawdzenie przedziału określoności zmiennej X: PB_X > 1
                if (PB_X > 1.0F)
                {
                    PB_dgpxd.Text = "X należy do przedziału (X > 1), "
                    + "Zdefiniuj dolną granicę dla funkcji F(x)";
                    PB_ggpfg.Text = "X należy do przedziału (X > 1), "
                    + "Zdefiniuj Górną granicę dla funkcji F(x)";

                    //sprawdzenie czy do kontrolki PB_DolnaGranicaPrzedzialuFD 
                    // wprowadzono dane
                    if (String.IsNullOrEmpty(PB_DolnaGranicaPrzedzialuFD.Text))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                        errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                    "ERROR: musisz podać dolną wartość przedziału Xd");
                        return false;
                        // zakończenie sprawdzania czy wpisano cokolwiek 
                        // do kontrolki PB_DolnaGranicaPrzedzialuFD
                    }

                    // wczytanie wartości zmiennej Xd ze sprawdzeniem poprawności zapisu 
                    if (!double.TryParse(PB_DolnaGranicaPrzedzialuFD.Text, out PB_Xd))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                        errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                            "ERROR: wystąpił niedozwolony znak w zapisie"
                            + "wartości zmiennej Xd");
                        return false;
                        // zakończenie sprawdzania poprawności danych
                        // wprowadzonych do kontrolki PB_DolnaGranicaPrzedzialuFD 
                    }

                    // sprawdzenie czy wprowadzona wartość PB_Xd mieści się w zakresie
                    //określoności funkcji F(x) dla wprowadzonego parametru X
                    if (PB_Xd <= 1.0F)
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                        errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                            "ERROR: Dla wprowadzonej wartości X, wartość minimalna musi spełniać równanie (Fd > 1) ");
                        return false;
                        // zakończenie realizacji sprawdzenia czy PB_Xd mieści się w zakresie określoności 
                    }

                    // sprawdzenie czy wpisano coś do kontrolki dolnej granicy PB_Xg
                    if (String.IsNullOrEmpty(PB_GornaGranicaPrazedzialuFG.Text))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                        errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                    "ERROR: musisz podać górną wartość przedziału Xg");
                        return false;
                        // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_GornaGranicaPrazedzialuFG
                    }

                    // wczytanie danych i sprawdzenie poproawności formatu w kotrolce PB_GornaGranicaPrazedzialuFG
                    if (!double.TryParse(PB_GornaGranicaPrazedzialuFG.Text, out PB_Xg))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                        errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                        "ERROR: urzyto niedozwolonych znaków w zapisie parametru Xg");
                        return false;
                        // zakończenie sprawdzania poprawności wprowadzonych
                        // danych do kontrolki PB_GornaGranicaPrazedzialuFG
                    }

                    // sprawdzenie czy wprowadzona gorna granica miesci sie w zakresie
                    if (PB_Xg <= 1.0F)
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                        errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                            "ERROR: Dla wprowadzonej wartości X, wartość maksymalna musi spełniać równanie (Fg > 1) ");
                        return false;
                        // zakończenie realizacji sprawdzenia czy PB_Xg mieści się w zakresie określoności 
                    }

                    // sprawdzenie czy wprowadzona wartość maksymalna PB_Xg nie jest mniejsza od PB_Xd
                    if (PB_Xd > PB_Xg)
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                        errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                        "ERROR: Wartość maksymalna Xg nie może być mniejsza od minimalnej Xd ");
                        return false;
                        // zakończenie realizacji sprawdzenia czy PB_Xg nie jest wieksza od X
                    }

                    // sprawdzenie poprawności wprowadzenia danych do kontrolki PB_h
                    if (String.IsNullOrEmpty(PB_KrokPrzyrostuHFX.Text))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                        errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                    "ERROR: msisz podać wartośc ktroku przeliczeniowego h");
                        return false;
                        // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_KrokPrzyrostuHFX
                    }

                    // wczytanie danych i sprawdzenie poprawności formatu danych dla PB_h
                    if (!double.TryParse(PB_KrokPrzyrostuHFX.Text, out PB_h))
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                        errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                    "ERROR: użyto nieprawidłowego znaku. Wprowadźpoprawnie wartość kroku h");
                        return true;
                        // zakonczenie sprawdzania czy poproawnie wprowadzono wartość kroku h
                    }

                    // sprawdzenie, czy wartośc kroku H nie jest mniejsza od 0
                    if (PB_h <= 0.0F)
                    {
                        // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                        errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                    "ERROR: wartośc kroku przyrostu obliczeń nie może być równy, mniejszy niż (0)");
                        return true;
                        // zakonczenie sprawdzania czy wartość kroku h nie jest równa lub mniejsza od 0
                    }
                    // zgaszenie kontrolki errorProvider1
                    errorProvider1.Dispose();

                }
                // Okreslenie przedziału zmiennej X (-1 <= X <= 1)
                else
                    if ((PB_X >= -1) && (PB_X <= 1))
                    {
                        PB_dgpxd.Text = "X należy do przedziału (-1 <= X <= 1), "
                        + "Zdefiniuj dolną granicę dla funkcji F(x)";
                        PB_ggpfg.Text = "X należy do przedziału (-1 <= X <= 1), "
                        + "Zdefiniuj Górną granicę dla funkcji F(x)";

                        //sprawdzenie czy do kontrolki PB_DolnaGranicaPrzedzialuFD wprowadzono dane
                        if (String.IsNullOrEmpty(PB_DolnaGranicaPrzedzialuFD.Text))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                            errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                        "ERROR: musisz podać dolną wartość przedziału Xd");
                            return false;
                            // zakończenie sprawdzania czy wpisano cokolwiek
                            //do kontrolki PB_DolnaGranicaPrzedzialuFD
                        }

                        // wczytanie wartości zmiennej PB_Xd ze sprawdzeniem poprawności zapisu 
                        if (!double.TryParse(PB_DolnaGranicaPrzedzialuFD.Text, out PB_Xd))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                                "ERROR: wystąpił niedozwolony znak w zapisie"
                                + "wartości zmiennej Xd");
                            return false;
                            // zakończenie sprawdzania poprawności danych
                            // wprowadzonych do kontrolki PB_DolnaGranicaPrzedzialuFD 
                        }

                        // sprawdzenie czy wprowadzona wartość mieści się w zakresie
                        //określoności funkcji F(x) dla wprowadzonego parametru X
                        if (PB_Xd < -1)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                                "ERROR: Dla wprowadzonej wartości X, wartość minimalna musi spełniać równanie (-1 < Fd < 1) ");
                            return false;
                            // zakończenie realizacji sprawdzenia czy PB_Fd mieści się w zakresie określoności od dolu
                        }

                        if (PB_Xd > 1)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_DolnaGranicaPrzedzialuFD,
                                "ERROR: Dla wprowadzonej wartości X, wartość minimalna musi spełniać równanie (-1 < Fd < 1) ");
                            return false;
                            // zakończenie realizacji sprawdzenia czy Fd mieści się w zakresie określoności od gory
                        }

                        // sprawdzenie czy wpisano coś do kontrolki dolnej granicy Xg
                        if (String.IsNullOrEmpty(PB_GornaGranicaPrazedzialuFG.Text))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                            errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                        "ERROR: musisz podać górną wartość przedziału Xg");
                            return false;
                            // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_GornaGranicaPrazedzialuFG
                        }

                        // wczytanie danych i sprawdzenie poproawności formatu w kotrolce PB_GornaGranicaPrazedzialuFG
                        if (!double.TryParse(PB_GornaGranicaPrazedzialuFG.Text, out PB_Xg))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                            errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                            "ERROR: urzyto niedozwolonych znaków w zapisie parametru Xg");
                            return false;
                            // zakończenie realizacji wczytania danych i sprawdzenia 
                            //czy wpisano coś do kontrolki PB_GornaGranicaPrazedzialuFG
                        }

                        // sprawdzenie czy dolna granica PB_Xg miesci sie z zakresie okreslonosci
                        if (PB_Xg < -1)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                                "ERROR: Dla wprowadzonej wartości X, wartość maksymalna musi spełniać równanie (-1 < Xg < 1) ");
                            return false;
                            // zakończenie realizacji sprawdzenia czy PB_Xg mieści się w zakresie określoności od dolu 
                        }

                        if (PB_Xg > 1)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                                "ERROR: Dla wprowadzonej wartości X, wartość maksymalna musi spełniać równanie (-1 < Xg < 1) ");
                            return false;
                            // zakończenie realizacji sprawdzenia czy PB_Xg mieści się w zakresie określoności od gory
                        }

                        // sprawdzenie czy wprowadzona wartość maksymalna Xg ie jest mniejsza od Xd
                        if (PB_Xd > PB_Xg)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_GornaGranicaPrazedzialuFG,
                            "ERROR: Wartość maksymalna Xg nie może być mniejsza od minimalnej Xd ");
                            return false;
                            // zakończenie realizacji sprawdzenia czy PB_Xg nie jest wieksza od PB_Xd
                        }

                        // sprawdzenie poprawności wprowadzenia danych dla zmiennej roku PB_h
                        if (String.IsNullOrEmpty(PB_KrokPrzyrostuHFX.Text))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu 
                            errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                        "ERROR: msisz podać wartośc ktroku przeliczeniowego h");
                            return false;
                            // zakończenie realizacji sprawdzenia czy wpisano coś do kontrolki PB_KrokPrzyrostuHFX
                        }

                        // wczytanie danych i sprawdzenie poprawności formatu danych dla zmienej PB_h
                        if (!double.TryParse(PB_KrokPrzyrostuHFX.Text, out PB_h))
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                        "ERROR: użyto nieprawidłowego znaku. Wprowadźpoprawnie wartość kroku h");
                            return false;
                            // zakonczenie sprawdzania czy poproawnie wprowadzono wartość kroku h
                        }

                        // sprawdzenie, czy wartośc kroku H nie jest mniejsza od 0
                        if (PB_h <= 0.0F)
                        {
                            // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                            errorProvider1.SetError(PB_KrokPrzyrostuHFX,
                        "ERROR: wartośc kroku przyrostu obliczeń nie może być równy, mniejszy niż (0)");
                            return true;
                            // zakonczenie sprawdzania czy wartość kroku h nie jest równa lub mniejsza od 0
                        }

                    }
            // zgaszenie zapalonej kontrolki błędu
            errorProvider1.Clear();
            return true;
        }





        // Obliczanie wartości funkcji F(x) dla zadeklarowanej wartości X
        // w zależności od przedziału określonści
        private void PB_ObliczenieWartosciFunkcjiWPrzedziale_Click(object sender, EventArgs e)
        {

            // deklaracja zmiennych lokalnych
            double PB_PrzechowajX;
            double PB_X;
            double PB_Xd;
            double PB_Xg;
            double PB_h;

            // pobieranie danych wejściowych dla obsługi zdarzenia: Click
            if (!PB_OkresleniePrzedzialuFunkcjiFX(out PB_X, out PB_Xd, out PB_Xg, out PB_h))
                return;

            // przypisanie zmeiennej tymczasowej wartości wczytanego parametru X
            PB_PrzechowajX = PB_X;

            // ukrycie form DataGridView i chart
            PB_TabelaWartosciFunkcjiFx.Visible = false;
            PB_WykresPrzebieguFunkcji.Visible = false;

            // wykonanie obliczeń i wyprowadzenie wyniku na ekran
            // dla zakresu określoności X < -1
            if (PB_X < -1.0F)
            {
                PB_Wyliczone_Y = 1.0F / (double)Math.Pow(PB_X, 6);              // obliczenie wartości funkcji w zakresie
                PB_wf_x.Visible = true;                                         // wyświetlenie kontrolki opisowej label
                PB_Fx_wynik.Visible = true;                                     // wyświetlenie kontrolki label dla wyniku
                PB_Fx_wynik.Text = PB_Wyliczone_Y.ToString("0.0000000000");     // wyprowadzenie wyniku na ekran i sformatowanie 
                                                                                // wyświetlania wyniku obliczeń
                return;
            }

            // wykonanie obliczeń i wyprowadzenie wyniku na ekran
            // dla zakresu określoności X > 1
            if (PB_X > 1.0F)
            {
                PB_Wyliczone_Y = (double)Math.Pow(PB_X, 3) * (double)Math.Pow(1 / PB_X, 4); // obliczenie wartości funkcji w zakresie
                PB_wf_x.Visible = true;                                                     // wyświetlenie kontrolki opisowej label
                PB_Fx_wynik.Visible = true;                                                 // wyświetlenie kontrolki label dla wyniku
                PB_Fx_wynik.Text = PB_Wyliczone_Y.ToString("0.00");                         // wyprowadzenie wyniku na ekran i sformatowanie
                                                                                            // wyświetlania wyniku obliczeń
                return;
            }

            // wykonanie obliczeń i wyprowadzenie wyniku na ekran
            // dla zakresu określoności -1 < X < 1
            else
            {
                PB_Wyliczone_Y = PB_X + PB_X;                       // obliczenie wartości funkcji w zakresie
                PB_wf_x.Visible = true;                             // wyświetlenie kontrolki opisowej label
                PB_Fx_wynik.Visible = true;                         // wyświetlenie kontrolki label dla wyniku
                PB_Fx_wynik.Text = PB_Wyliczone_Y.ToString("0.00"); // wyprowadzenie wyniku na ekran i sformatowanie
                                                                    // wyświetlania wyniku obliczeń
            }
            return;
        }

        // obsługa przycisku wyboru koloru linii wykresu
        private void PB_WybierzKolorLiniiWykresu_Click(object sender, EventArgs e)
        {
            // wywołanie okna systemowewgo z paletą kolorów
            ColorDialog PB_OknoKoloruLinii = new ColorDialog();
            // sprawdzenie czy użytkownik wybrał przycisk polecen "OK", 
            // i jeśli tak to ustawiamy kolor linii
            if (PB_OknoKoloruLinii.ShowDialog() == DialogResult.OK)
            {
                PB_WybranyKolorLinii.BackColor = PB_OknoKoloruLinii.Color;
            }
        }
        // zakończenie obsługi przycisku wyboru koloru linii wykresu


        // obsługa przycisku wyboru koloru tła wykresu
        private void PB_WybierzKolorTlaWykresu_Click(object sender, EventArgs e)
        {
            // wywołanie okna systemowewgo z paletą kolorów
            ColorDialog PB_OkienkoKoloruTla = new ColorDialog();
            // sprawdzenie czy użytkownik wybrał przycisk polecen "OK", 
            // i jeśli tak to ustawiamy kolor tła
            if (PB_OkienkoKoloruTla.ShowDialog() == DialogResult.OK)
            {
                PB_WybranyKolorTla.BackColor = PB_OkienkoKoloruTla.Color;
            }
        }
        // zakończenie obsługi przycisku wyboru koloru tła wykresu



        // obsługa przycisku Tabelarycznej Wizualizacji funkcji F(x) w zakresie określoności
        private void PB_TabelarycznaWizualizacjaWartosciFx_Click(object sender, EventArgs e)
        {
            // ustawienie wartości początkowej ilości rzędów na 1
            PB_TabelaWartosciFunkcjiFx.RowCount = 1;

            // deklaracje lokalne
            double PB_X;
            double PB_Xd;
            double PB_Xg;
            double PB_h;
            double PB_Fx;
            int PB_IloscWierszyTabeli;

            PB_Fx = PB_Wyliczone_Y;         // przypisanie zmienej PB_Fx wartości otrzymanej po obliczeniu funkcji
            PB_IloscWierszyTabeli = 0;      // ustawienie wartości początkowej zmmiennej wyliczeniowej 
                                            // dla ilości powtuzeń obliczeń punktó wykresu

            // pobranie danych wejściowych dla obsługi zdarzenia Click
            if (!PB_OkresleniePrzedzialuFunkcjiFX(out PB_X, out PB_Xd, out PB_Xg, out PB_h))
                return;

            // sprawdzenie warunku dla pierwszego zakresu określoności (X < -1)
            if (PB_X < -1.0F)
            {
                // wywołąnie zmiennej pomocniczej do przechowania wartości dolnej granicy przedziału
                double PB_tymczas;
                PB_tymczas = PB_Xd;

                while (PB_tymczas <= PB_Xg)         // wywołanie pętli obliczającej wartość ilości powtórzeń 
                                                    // dla obliczania wartości Y dla punktu przeliczeniowego F(x)
                {
                    PB_tymczas = PB_tymczas + PB_h;
                    PB_IloscWierszyTabeli++;
                }

                // deklaracja tablicy wartości funkcji dla kolejnych kroków H
                double[,] TablicaWartosciFunkcji = new double[PB_IloscWierszyTabeli, 2];

                // odsłonięcie formy DataGridView
                PB_TabelaWartosciFunkcjiFx.Visible = true;

                // ukrycie formy chart
                PB_WykresPrzebieguFunkcji.Visible = false;

                // Wywołanie zmiennej kroku tablicy
                int PB_i;

                // ustawienie wartości początkowej dla zmiennej kroku tablicy
                PB_i = 0;
                do
                {
                    // wywołanie nowej tablicy
                    PB_TabelaWartosciFunkcjiFx.Rows.Add();

                    // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                    TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                    // przepisanie wartosci dolnej granicy do tabeli
                    PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[0].Value = PB_Xd.ToString();
                    PB_X = PB_Xd;

                    // obliczenie wartości funkcji dla danego X
                    PB_Wyliczone_Y = 1.0F / (double)Math.Pow(PB_X, 6);

                    // przepisanie wartości Y do tabeli
                    PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[1].Value = string.Format("{0:F10}", PB_Wyliczone_Y);

                    // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                    PB_i++;

                    // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                    PB_Xd = PB_Xd + PB_h;

                }
                // warunek zakonczenia wykonywania pętli
                while (PB_Xd <= PB_Xg);
            }

            else
                // sprawdzenie warunku dla 2-go zakresu określoności (X > 1)
                if (PB_X > 1.0F)
                {
                    // wywołąnie zmiennej pomocniczej do przechowania wartości dolnej granicy przedziału
                    double PB_tymczas;
                    PB_tymczas = PB_Xd;

                    while (PB_tymczas <= PB_Xg)             // wywołanie pętli obliczającej wartość ilości powtórzeń 
                                                            // dla obliczania wartości Y dla punktu przeliczeniowego F(x)
                    {
                        PB_tymczas = PB_tymczas + PB_h;
                        PB_IloscWierszyTabeli++;
                    }

                    // deklaracja tablicy wartości funkcji dla kolejnych kroków H
                    double[,] TablicaWartosciFunkcji = new double[PB_IloscWierszyTabeli, 2];

                    // odsłonięcie formy DataGridView
                    PB_TabelaWartosciFunkcjiFx.Visible = true;

                    // ukrycie formy chart
                    PB_WykresPrzebieguFunkcji.Visible = false;

                    // Wywołanie zmiennej kroku tablicy
                    int PB_i;

                    // ustawienie wartości początkowej dla zmiennej kroku tablicy
                    PB_i = 0;
                    do
                    {
                        // wywołanie nowej tablicy
                        PB_TabelaWartosciFunkcjiFx.Rows.Add();

                        // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                        TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                        // przepisanie wartosci dolnej granicy do tabeli
                        PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[0].Value = PB_Xd.ToString();
                        PB_X = PB_Xd;

                        // obliczenie wartości funkcji dla danego X
                        PB_Wyliczone_Y = (double)Math.Pow(PB_X, 3) * (double)Math.Pow(1 / PB_X, 4);

                        // przepisanie wartości Y do tabeli
                        PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[1].Value = string.Format("{0:F3}", PB_Wyliczone_Y);

                        // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                        PB_i++;

                        // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                        PB_Xd = PB_Xd + PB_h;

                    }
                    // warunek zakonczenia wykonywania pętli
                    while (PB_Xd <= PB_Xg);
                }

                else
                    // sprawdzenie warunku dla trzeciego zakresu określoności (-1 < X < 1)
                    if ((PB_X >= -1.0F) && (PB_X <= 1))
                    {
                        // wywołąnie zmiennej pomocniczej do przechowania wartości dolnej granicy przedziału
                        double PB_tymczas;
                        PB_tymczas = PB_Xd;

                        while (PB_tymczas <= PB_Xg)             // wywołanie pętli obliczającej wartość ilości powtórzeń 
                                                                // dla obliczania wartości Y dla punktu przeliczeniowego F(x)
                        {
                            PB_tymczas = PB_tymczas + PB_h;
                            PB_IloscWierszyTabeli++;
                        }

                        // deklaracja tablicy wartości funkcji dla kolejnych kroków H
                        double[,] TablicaWartosciFunkcji = new double[PB_IloscWierszyTabeli, 2];

                        // odsłonięcie formy DataGridView
                        PB_TabelaWartosciFunkcjiFx.Visible = true;

                        // ukrycie formy chart
                        PB_WykresPrzebieguFunkcji.Visible = false;

                        // Wywołanie zmiennej kroku tablicy
                        int PB_i;

                        // ustawienie wartości początkowej dla zmiennej kroku tablicy
                        PB_i = 0;
                        do
                        {
                            // wywołanie nowej tablicy
                            PB_TabelaWartosciFunkcjiFx.Rows.Add();

                            // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                            TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                            // przepisanie wartosci dolnej granicy do tabeli
                            PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[0].Value = PB_Xd.ToString();
                            PB_X = PB_Xd;

                            // obliczenie wartości funkcji dla danego X
                            PB_Wyliczone_Y = PB_X + PB_X;

                            // przepisanie wartości Y do tabeli
                            PB_TabelaWartosciFunkcjiFx.Rows[PB_i].Cells[1].Value = string.Format("{0:F3}", PB_Wyliczone_Y);

                            // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                            PB_i++;

                            // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                            PB_Xd = PB_Xd + PB_h;

                        }
                        // warunek zakonczenia wykonywania pętli
                        while (PB_Xd <= PB_Xg);
            }
        }

        // wywołanie metody obsługi przycisku graficznej wizualizacji funkcji F(x)
        private void PB_GraficznaWizualizacjaFx_Click(object sender, EventArgs e)
        {
            // Wyczyszczenie obszaru wykresu przed naniesieniem zmian
            PB_WykresPrzebieguFunkcji.ResetAutoValues();
            PB_WykresPrzebieguFunkcji.Titles.Clear();

            // deklaracje lokalne

            double PB_X;
            double PB_Xd;
            double PB_Xg;
            double PB_h;
            double PB_Fx;
            int PB_Krok;

            PB_Fx = 0;
            PB_Krok = 0;

            // wyświetlenie elementów do formatowania wykresu

            // pobranie danych wejściowych dla obsługi zdarzenia Click
            if (!PB_OkresleniePrzedzialuFunkcjiFX(out PB_X, out PB_Xd, out PB_Xg, out PB_h))
                return;

            // został wykryty błąd przy pobieraniu danych wejściowych i obsługa
            // zdarzenia Click została przerwana

            // wywołąnie zmiennej pomocniczej do przechowania wartości dolnej granicy przedziału
            double PB_tymczas;
            PB_tymczas = PB_Xd;

            while (PB_tymczas <= PB_Xg)             // wywołanie pętli obliczającej ilość powtórzeń 
                                                    // pętli liczącej współrzędne X i Y
            {
                PB_tymczas = PB_tymczas + PB_h;
                PB_Krok++;
            }

            // deklaracja tablicy wartości funkcji dla kolejnych kroków H
            double[,] PB_TablicaWartosciFunkcji = new double[PB_Krok, 2];

            // ukrycie formy DataGridView
            PB_TabelaWartosciFunkcjiFx.Visible = false;

            // odsłonięcie formy chart
            PB_WykresPrzebieguFunkcji.Visible = true;

            // Wywołanie zmiennej kroku tablicy
            int PB_i;

            // ustawienie wartości początkowej dla zmiennej kroku tablicy
            PB_i = 0;

            // wykonanie obliczeń i wyrysowanie wykresu dla pierwszego zakresu określoności (X < -1)
            if (PB_X < -1.0F)
            {
                do
                {
                    // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                    PB_TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                    // przepisanie wartosci dolnej granicy do współrzędnej X
                    PB_X = PB_Xd;

                    // obliczenie wartości funkcji dla danego X
                    PB_Fx = 1.0F / (double)Math.Pow(PB_X, 6);

                    // wstawienie wartosci wspolrzednej Y do tablicy
                    PB_TablicaWartosciFunkcji[PB_i, 1] = PB_Fx;


                    // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                    PB_i++;

                    // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                    PB_Xd = PB_Xd + PB_h;

                }
                // warunek zakonczenia wykonywania pętli
                while (PB_Xd <= PB_Xg);
                // formatowanie obszaru wykresu
                PB_WykresPrzebieguFunkcji.Titles.Add("Przebieg zmienności Funkcji F(x) dla zadanego zakresu");
                PB_WykresPrzebieguFunkcji.BackColor = PB_WybranyKolorTla.BackColor;                 // kolor tła wykresu
                PB_WykresPrzebieguFunkcji.Series[0].Name = "Wykres Funkcji";                        // legenda
                PB_WykresPrzebieguFunkcji.Series[0].ChartType = SeriesChartType.Line;               // wykres liniowy
                PB_WykresPrzebieguFunkcji.Series[0].Color = PB_WybranyKolorLinii.BackColor;         // niebieski kolor linii
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Title = "Oś  X";                      // Domyślna wartość opisu dla osi X
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Title = "Oś  Y";                      // Domyślna wartość opisu dla osi Y
                PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 1;                                // grubość linii 2 piksele

                // Wykres

                // Deklaracja zmiennych pomocniczych wykresu i wyliczenie wartosci X i Y do punktow na wykresie
                double[] PB_Wspolrzedna1 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                    PB_Wspolrzedna1[PB_Pozycja] = PB_Pozycja;
                double[] PB_Współrzędna2 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                    PB_Współrzędna2[PB_Pozycja] = PB_TablicaWartosciFunkcji[PB_Pozycja, 1];

                //Podpięcie tablic z punktami X i Y do kontrolki typu chart
                PB_WykresPrzebieguFunkcji.Series[0].Points.DataBindXY(PB_Wspolrzedna1, PB_Współrzędna2);

                return;
            }

            else
                // wykonanie obliczeń i wyrysowanie wykresu dla 2-go zakresu określoności (X > 1)
                if (PB_X > 1.0F)
                {
                    do
                    {
                        // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                        PB_TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                        // przepisanie wartosci dolnej granicy do współrzędnej X
                        PB_X = PB_Xd;

                        // obliczenie wartości funkcji dla danego X
                        PB_Fx = (double)Math.Pow(PB_X, 3) * (double)Math.Pow(1 / PB_X, 4);

                        // wstawienie wartosci wspolrzednej Y do tablicy
                        PB_TablicaWartosciFunkcji[PB_i, 1] = PB_Fx;


                        // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                        PB_i++;

                        // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                        PB_Xd = PB_Xd + PB_h;


                    }
                    // warunek zakonczenia wykonywania pętli
                    while (PB_Xd <= PB_Xg);
                    // formatowanie obszaru wykresu
                    PB_WykresPrzebieguFunkcji.Titles.Add("Przebieg zmienności Funkcji F(x) dla zadanego zakresu");
                    PB_WykresPrzebieguFunkcji.BackColor = PB_WybranyKolorTla.BackColor;                 // kolor tła wykresu
                    PB_WykresPrzebieguFunkcji.Series[0].Name = "Wykres Funkcji";                        // legenda
                    PB_WykresPrzebieguFunkcji.Series[0].ChartType = SeriesChartType.Line;               // wykres liniowy
                    PB_WykresPrzebieguFunkcji.Series[0].Color = PB_WybranyKolorLinii.BackColor;         // niebieski kolor linii
                    PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Title = "Oś  X";                      // Domyślna wartość opisu dla osi X
                    PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Title = "Oś  Y";                      // Domyślna wartość opisu dla osi Y
                    PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 1;                                // grubość linii 2 piksele

                    // Wykres

                    // Deklaracja zmiennych pomocniczych wykresu i wyliczenie wartosci X i Y do punktow na wykresie
                    double[] PB_Wspolrzedna1 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                    for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                        PB_Wspolrzedna1[PB_Pozycja] = PB_Pozycja;
                    double[] PB_Współrzędna2 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                    for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                        PB_Współrzędna2[PB_Pozycja] = PB_TablicaWartosciFunkcji[PB_Pozycja, 1];

                    //Podpięcie tablic z punktami X i Y do kontrolki typu chart
                    PB_WykresPrzebieguFunkcji.Series[0].Points.DataBindXY(PB_Wspolrzedna1, PB_Współrzędna2);
                    return;
                }

                else
                    // wykonanie obliczeń i wyrysowanie wykresu dla trzeciego zakresu określoności (-1 < X < 1)
                    if ((PB_X >= -1.0F) && (PB_X <= 1))
                    {
                        do
                        {
                            // przypisanie pierwszej współrzędnej X wartości dolnej zakresu PB_Xd
                            PB_TablicaWartosciFunkcji[PB_i, 0] = PB_Xd;

                            // przepisanie wartosci dolnej granicy do współrzędnej X
                            PB_X = PB_Xd;

                            // obliczenie wartości funkcji dla danego X
                            PB_Fx = PB_X + PB_X;

                            // wstawienie wartosci wspolrzednej Y do tablicy
                            PB_TablicaWartosciFunkcji[PB_i, 1] = PB_Fx;


                            // dla kolejnej petli dodanie 1 wiersza do indeksu tabeli
                            PB_i++;

                            // zmiana wartości obliczanego X, powiększenie o krok przeliczeniowy H
                            PB_Xd = PB_Xd + PB_h;

                        }
                        // warunek zakonczenia wykonywania pętli
                        while (PB_Xd <= PB_Xg);
                        // formatowanie obszaru wykresu
                        PB_WykresPrzebieguFunkcji.Titles.Add("Przebieg zmienności Funkcji F(x) dla zadanego zakresu");
                        PB_WykresPrzebieguFunkcji.BackColor = PB_WybranyKolorTla.BackColor;                 // kolor tła wykresu
                        PB_WykresPrzebieguFunkcji.Series[0].Name = "Wykres Funkcji";                        // legenda
                        PB_WykresPrzebieguFunkcji.Series[0].ChartType = SeriesChartType.Line;               // wykres liniowy
                        PB_WykresPrzebieguFunkcji.Series[0].Color = PB_WybranyKolorLinii.BackColor;         // niebieski kolor linii
                        PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Title = "Oś  X";                      // Domyślna wartość opisu dla osi X
                        PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Title = "Oś  Y";                      // Domyślna wartość opisu dla osi Y
                        PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 1;                                // grubość linii 2 piksele


                        // Wykres

                        // Deklaracja zmiennych pomocniczych wykresu i wyliczenie wartosci X i Y do punktow na wykresie
                        double[] PB_Wspolrzedna1 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                        for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                            PB_Wspolrzedna1[PB_Pozycja] = PB_Pozycja;
                        double[] PB_Współrzędna2 = new double[PB_TablicaWartosciFunkcji.GetLength(0)];
                        for (int PB_Pozycja = 0; PB_Pozycja < PB_TablicaWartosciFunkcji.GetLength(0); PB_Pozycja++)
                            PB_Współrzędna2[PB_Pozycja] = PB_TablicaWartosciFunkcji[PB_Pozycja, 1];

                        //Podpięcie tablic z punktami X i Y do kontrolki typu chart
                        PB_WykresPrzebieguFunkcji.Series[0].Points.DataBindXY(PB_Wspolrzedna1, PB_Współrzędna2);
                        return;
             }
        }

        // ustawienie domyślnej wartości dla rodzaju linii wykresu
        ChartDashStyle PB_wybranyStyl = ChartDashStyle.DashDot;

        // definiowanie rodzaju linii użytej do prezentacji funkcji F(x)
        private void PB_WybranyStylLinii_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                // przypisanie zmienej tymczasowej wartości wypranej indexu kontrolki ComboBox
                int PB_SelectedIndex = PB_WybranyStylLinii.SelectedIndex;
                Object PB_SelectedItem = PB_WybranyStylLinii.SelectedItem;

                // określenie typu linii w zależności od wyboru użytkownika
                switch (PB_SelectedIndex)
                {
                    case 0:
                        PB_wybranyStyl = ChartDashStyle.Dash;
                        break;
                    case 1:
                        PB_wybranyStyl = ChartDashStyle.DashDot;
                        break;
                    case 2:
                        PB_wybranyStyl = ChartDashStyle.DashDotDot;
                        break;
                    case 3:
                        PB_wybranyStyl = ChartDashStyle.Dot;
                        break;
                    case 4:
                        PB_wybranyStyl = ChartDashStyle.Solid;
                        break;
                }

                // przepisanie wyboru urzytkownika do kontrolki TextBox jako wziernik wzorca wybranej linii
                PB_WykresPrzebieguFunkcji.Series[0].BorderDashStyle = PB_wybranyStyl;
                if (PB_wybranyStyl == ChartDashStyle.Dash)
                    PB_WziernikWzorcaLinii.Text = "- - - - - - - -";
                if (PB_wybranyStyl == ChartDashStyle.DashDot)
                    PB_WziernikWzorcaLinii.Text = "ˑ - ˑ - ˑ - ˑ - ˑ";
                if (PB_wybranyStyl == ChartDashStyle.DashDotDot)
                    PB_WziernikWzorcaLinii.Text = "- ˑˑ - ˑˑ - ˑˑ -";
                if (PB_wybranyStyl == ChartDashStyle.Dot)
                    PB_WziernikWzorcaLinii.Text = "ˑ ˑ ˑ ˑ ˑ ˑ ˑ ";
                if (PB_wybranyStyl == ChartDashStyle.Solid)
                    PB_WziernikWzorcaLinii.Text = "————————————";

            }
        }
        // wywołanie metody obsługi sówaka  w celu określenia krokowego grubości linii wykresu
        private void PB_GruboscLiniiWykresu_Scroll(object sender, EventArgs e)
        {
            int PB_GruboscLinii;                                // wywołanie zmienej pomocniczej
            PB_GruboscLinii = PB_GruboscLiniiWykresu.Value;     // rzypisanie wyboru użytkownika do zmienej pomocniczej

            // przepisanie wyboru urzytkownika do definicji grubości linii wykresu w kontrolce chart
            if (PB_GruboscLinii == 1)
            {
            PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 1;
            }
            else
                if (PB_GruboscLinii == 2)
                {
                    PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 2;
                }
                else
                    if (PB_GruboscLinii == 3)
                    {
                        PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 3;
                    }
                    else
                        if (PB_GruboscLinii == 4)
                        {
                            PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 4;
                        }
                        else
                            if (PB_GruboscLinii == 5)
                            {
                                PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = 5;
                            }
        }

        // wywołanie metody recznej definicji grubości linii dla wykresu w kontrolce chart
        private void PB_OdrecznaDefinicjaGrubosciLinii_TextChanged(object sender, EventArgs e)
        {

            // deklaracja zmiennej pomocniczej
            double PB_ZadeklaowanaGruboscLinii;

            // sprawdzenie, czy w kontrolce wprowadzono poprawny znak
            if (!double.TryParse(PB_OdrecznaDefinicjaGrubosciLinii.Text, out PB_ZadeklaowanaGruboscLinii))
            {
                // zapalenie kontrolki errorProvider, czyli sygnalizacja błędu
                errorProvider1.SetError(PB_OdrecznaDefinicjaGrubosciLinii,
                "ERROR: użyto nieprawidłowego znaku. Wprowadź poprawnie wartość grubości linii");
                return;
                // zakonczenie sprawdzania czy poproawnie wprowadzono wartość kroku h
            }
            // wyłączenie kontrolki błędu
            errorProvider1.Dispose();

            // przyypisanie wartości określonej przez urzytkownika 
            // zmienej określającej grubość linii na wykresie
            PB_WykresPrzebieguFunkcji.Series[0].BorderWidth = (int)PB_ZadeklaowanaGruboscLinii;
        }

        // wywołanie metody wyłączającej siatkę, opis ukłądu współrzędnych i wizualizację wartości
        // dla przycisku RadioButton
         private void PB_WykreslLinieUWBezOpisu_CheckedChanged(object sender, EventArgs e)
        {
             // określenie akcji po zaznaczeniu kontrolki zgaszenia opisu wykresu
            if (PB_WykreslLinieUWBezOpisu.Checked)
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;  // opis, siatkę i skalę dla osi X wyłącz
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;  // opis, siatkę i skalę dla osi Y wyłącz
        }
         // wywołanie metody włączającej siatkę, opis ukłądu współrzędnych i wizualizację wartości
         // dla przycisku RadioButton
        private void PB_WykreslLinieUWZOpisem_CheckedChanged(object sender, EventArgs e)
        {
            // określenie akcji po zaznaczeniu kontrolki zgaszenia opisu wykresu
            if (PB_WykreslLinieUWZOpisem.Checked)
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;   // opis, siatkę i skalę włącz dla osi X
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisX.Title = "Oś  X";              // treść opisu
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;   // opis, siatkę i skalę włącz dla osi Y
                PB_WykresPrzebieguFunkcji.ChartAreas[0].AxisY.Title = "Oś  Y";              // treść opisu

        }
    }
} 



