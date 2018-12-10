using Final_AppDP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Final_AppDP
{
    public partial class Deliver : Form
    {
        BindingList<Store> stores;
        int auxVegetables = 0;
        int auxSodas = 0;
        int auxBread = 0;
        
        public Deliver(BindingList<Store> aux)
        {
            InitializeComponent();
            stores = aux;            
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            Logger.Log("The simulation began...");

            BindingList<Truck> trucks = new BindingList<Truck>();
            Dictionary<int, int> auxStores = new Dictionary<int, int>();            
            bool flag = true;
            int vegetable = (int)numVegetable.Value;
            int soda = (int)numSoda.Value;
            int bread = (int)numBread.Value;
            int total = vegetable + soda + bread;
            if (total == 0)
            {
                MessageBox.Show("You need minimum 1 truck", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logger.Log("The minimum amount of trucks is 1, try again");

            }
            else if (total > 5)
            {
                MessageBox.Show("You can have maximum 5 trucks", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logger.Log("The maximum amount of trucks is 5, try again");

            }
            else
            {
                for (int i = 0; i < vegetable; i++)
                    trucks.Add(new VegetablesTruck());
                for (int i = 0; i < soda; i++)
                    trucks.Add(new SodasTruck());
                for (int i = 0; i < bread; i++)
                    trucks.Add(new BreadTruck());
                for (int i = 1; i <= 3; i++)
                    auxStores.Add(i, 0);

                foreach (Store store in stores)
                    if (store.products != null)
                        foreach (Product product in store.products)
                            auxStores[product.idProduct] += product.quantity;

                foreach (Truck truck in trucks)
                    if (auxStores.TryGetValue(truck.Id, out int aux))
                        auxStores[truck.Id] -= truck.Quantity;

                foreach (KeyValuePair<int, int> entry in auxStores)
                    if (entry.Value > 0)
                        flag = false;
                if (flag)
                {
                    lblRes.ForeColor = Color.Green;
                    lblRes.Text = "You can deliver all your orders with the selected trucks.\n";
                    Logger.Log("Delivery is possible in simulation");
                    OKImage.Visible = true;
                    btnDeliver.Enabled = true;
                    foreach (KeyValuePair<int, int> entry in auxStores)
                        if (entry.Value < 0)
                            lblRes.Text += "Remaining " + -1 * entry.Value + " " + getType(entry.Key) + "\n";
                }
                else
                {
                    NOTImage.Visible = true;
                    lblRes.ForeColor = Color.Red;
                    lblRes.Text = "You cannot deliver all your orders with the selected trucks.\n";
                    Logger.Log("Delivery failed, is not possible to continue...");

                    btnDeliver.Enabled = false;
                    foreach (KeyValuePair<int, int> entry in auxStores)
                        if (entry.Value > 0)
                            lblRes.Text += "Missing " + entry.Value + " " + getType(entry.Key) + "\n";
                }
            }
        }        

        private void btnDeliver_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < stores.Count; i++)
            {                
                MessageBox.Show("Amount earned in this store $"+stores[i].totalPrice, "Delivering order to " + stores[i].storeName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                stores[i].products = null;
                if (stores[i].products == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to order any product for delivering tomorrow?", "New Order "+stores[i].storeName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Logger.Log(String.Format("New order created for {0}", stores[i].storeName));
                        using (MakeOrder make = new MakeOrder(stores[i]))
                        {
                            var result = make.ShowDialog();
                            if (result == DialogResult.OK)
                                stores[i] = make.store;
                        }                        
                    }
                    else
                    {
                        QRAdapter adapter = new QRAdapter();
                        adapter.SetStore(stores[i]);
                    }
                    stores[i].CalculateAmount();
                }                
            }
            Logger.Log("Delivery done");
            this.Close();
        }        

        private void numSoda_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (auxSodas > num.Value)
            {
                Logger.Log(String.Format("Decreased Number of soda trucks: using {0} trucks", num.Value));
                auxSodas = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("Increased Number of soda trucks: using {0} trucks", num.Value));
                auxSodas = (int)num.Value;
            }
        }

        private void numVegetable_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (auxVegetables > num.Value)
            {
                Logger.Log(String.Format("Decreased Number of vegetable trucks: using {0} trucks", num.Value));
                auxVegetables = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("Increased Number of vegetable trucks: using {0} trucks", num.Value));
                auxVegetables = (int)num.Value;
            }
        }

        private void numBread_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (auxBread > num.Value)
            {
                Logger.Log(String.Format("Decreased Number of bread trucks: using {0} trucks", num.Value));
                auxBread = (int)num.Value;
            }
            else
            {
                Logger.Log(String.Format("Increased Number of bread trucks: using {0} trucks", num.Value));
                auxBread = (int)num.Value;
            }
        }

        public string getType(int id)
        {
            if (id == 1)
                return "vegetables";
            else if (id == 2)
                return "sodas";
            else
                return "breads";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deliver_Load(object sender, EventArgs e)
        {

        }
    }
}
