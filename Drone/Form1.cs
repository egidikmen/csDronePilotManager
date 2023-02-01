using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Önceden 2 olan veritabanını tek veri tabanına indirdim.
        /// izinKontrol ve pilotTablo yu silip tek veri tabanında pilotun kişisel 
        /// bilgileri ve işaretlediği checkboxlar dataGridView'e kaydolmaktadır.
        /// üsste veritabanı oluşturunca otomatik gelen butonların içleri boş
        /// olduğu için yerine toolbox dan buton ekleyemedim
        ///ekleme silme ve kaydetme butonlarımız yukarıdaki barda mevcuttur.
        /// </summary>
        
        private void pilotBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pilotBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.pilot' table. You can move, or remove it, as needed.
            this.pilotTableAdapter.Fill(this.database1DataSet.pilot);

        }
    }
}
