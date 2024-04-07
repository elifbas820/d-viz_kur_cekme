using System.Xml;

namespace döviz_kur_cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void İşlem_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";

            XmlTextReader rdr = new XmlTextReader(bugun);
            var xmldosya = new XmlDocument();
            xmldosya.Load(rdr);

            string dolaral = "YOK";
            string dolarsat = "YOK";
            string euroal = "YOK";
            string eurosat = "YOK"
;

            XmlNode dolarAlisNode = xmldosya.SelectSingleNode("//Tarih_Date/Currency[@Kod='USD']/BanknoteBuying");
            if (dolarAlisNode != null)
            {
                dolaral = dolarAlisNode.InnerText;
            }

            lbldolaral.Text = dolaral;


            XmlNode dolarSatisNode = xmldosya.SelectSingleNode("//Tarih_Date/Currency[@Kod='USD']/BanknoteSelling");
            if (dolarSatisNode != null)
            {
                dolarsat = dolarSatisNode.InnerText;
            }
            lbldolarsat.Text = dolarsat;



            XmlNode euroAlisNode = xmldosya.SelectSingleNode("//Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying");
            if (euroAlisNode != null)
            {
                euroal = euroAlisNode.InnerText;
            }

            lbleuroal.Text = euroal;

            XmlNode euroSatisNode = xmldosya.SelectSingleNode("//Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling");
            if (euroSatisNode != null)
            {
                eurosat = euroSatisNode.InnerText;
            }

            lbleurosat.Text = eurosat;





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaral.Text;
        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsat.Text;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroal.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosat.Text;
        }

        private void btnsatışyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txttutar.Text = tutar.ToString();
            int kalan;
            kalan = miktar % tutar;
            txtkalan.Text = kalan.ToString();
        }
    }
}
