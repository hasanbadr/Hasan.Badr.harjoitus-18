using System.Data;

namespace Hasan.Badr.harjoitus18
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable Oppilaitos = new DataTable();// luodaan uusi tietitaulu
        DataTable VastuuHenkilot = new DataTable(); // luodaan uusi tietotaulu
        DataTable yhteys = new DataTable(); // luodaan uusi tietotaulu
        public AvainhenkilotForm()
        {
            InitializeComponent();
        }

        private void OppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = Oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OID"].ToString();
            OsoiteLB.Text = Oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OKatuosoite"].ToString();
            PostinumeroLB.Text = Oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPostinumero"].ToString();
            PostitoimipaikkaLB.Text = Oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            PuhelinLB.Text = Oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPuhelin"].ToString();

            yhteys = VastuuHenkilot.Select("OID =" + viite).CopyToDataTable();
            Vastuuhenkil�CB.DataSource = yhteys;
            Vastuuhenkil�CB.DisplayMember = "Name";
        }

        private void AvainhenkilotForm_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            OppilaitosCB.DataSource = Oppilaitos;
            OppilaitosCB.DataSource = "ONimi";
            TaytaVastuuHenkilotTaulukko();

        }
        private void taytaOppilaitosTaulukko()
        {
            Oppilaitos.Columns.Add("OID", typeof(int));
            Oppilaitos.Columns.Add("ONimi");
            Oppilaitos.Columns.Add("OKatuosoite");
            Oppilaitos.Columns.Add("OPostitoimipaikka");
            Oppilaitos.Columns.Add("OPuhelin");

            Oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            Oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            Oppilaitos.Rows.Add(3, "Varia", "R�lssitie 13", "01530", "Vantaa", "040 182 4668");
            Oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenv�yl� 55 A", "04400", "J�rvenp��", "09 27 381");
        }
        private void TaytaVastuuHenkilotTaulukko()
        {
            VastuuHenkilot.Columns.Add("OID", typeof(int));
            VastuuHenkilot.Columns.Add("VNimi");
            VastuuHenkilot.Columns.Add("VTitteli");
            VastuuHenkilot.Columns.Add("VSijainti");
            VastuuHenkilot.Columns.Add("VSahkoposti");
            VastuuHenkilot.Columns.Add("VPuhelin");

            VastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            VastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            VastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            VastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            VastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            VastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtym�n johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            VastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            VastuuHenkilot.Rows.Add(2, "Tuukko Soini", "Kehitt�misjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            VastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja ty�llisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            VastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            VastuuHenkilot.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            VastuuHenkilot.Rows.Add(2, "P�ivi Korhonen", "Viestint�johtaja", "Viestint�- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            VastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            VastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Ty�el�m�palvelup��llikk�", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            VastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden p��llikk�", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            VastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtym�n johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            VastuuHenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            VastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            VastuuHenkilot.Rows.Add(4, "Hanna Nyr�nen", "Viestint�- ja markkinointip��llikk�", "Viestint�palvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            VastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintap��llikk�", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }

        private void Vastuuhenkil�CB_TabStopChanged(object sender, EventArgs e)
        {
            TitteliLB.Text = yhteys.Rows[Vastuuhenkil�CB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = yhteys.Rows[Vastuuhenkil�CB.SelectedIndex]["VOsasto"].ToString();
            S�hk�postiLB.Text = yhteys.Rows[Vastuuhenkil�CB.SelectedIndex]["VSahkoposti"].ToString();
            PuhLB.Text = yhteys.Rows[Vastuuhenkil�CB.SelectedIndex]["VPuhelin"].ToString();

        }
    }
}