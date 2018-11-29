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

namespace Final_AppDP
{
    public partial class Deliver : Form
    {
        BindingList<Store> stores;     
        
        public Deliver(BindingList<Store> aux)
        {
            InitializeComponent();
            stores = aux;            
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            BindingList<Truck> trucks = new BindingList<Truck>();
            Dictionary<int, int> auxStores = new Dictionary<int, int>();
            bool flag = true;
            int vegetable = (int)numVegetable.Value;
            int soda = (int)numSoda.Value;
            int bread = (int)numBread.Value;
            int total = vegetable + soda + bread;
            if (total == 0)            
                MessageBox.Show("You need minimum 1 truck", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            else if (total > 5)            
                MessageBox.Show("You can have maximum 5 trucks", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            else
            {
                for (int i = 0; i < vegetable; i++)                
                    trucks.Add(new VegetablesTruck());
                for (int i = 0; i < soda; i++)
                    trucks.Add(new SodasTruck());
                for (int i = 0; i < bread; i++)
                    trucks.Add(new BreadTruck());
                foreach(Store store in stores)
                {
                    if (store.products != null)
                        foreach (Product product in store.products)
                        {
                            if (!auxStores.TryGetValue(product.idProduct, out int auxValue))
                                auxStores.Add(product.idProduct, product.quantity);
                            else                        
                                auxStores[product.idProduct] += product.quantity;                        
                        }                    
                }
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
                    btnDeliver.Enabled = true;
                    foreach (KeyValuePair<int, int> entry in auxStores)
                    {
                        if (entry.Value < 0)
                            lblRes.Text += "Remaining " + -1*entry.Value + " " + getType(entry.Key) + "\n";
                    }
                }                    
                else
                {
                    lblRes.ForeColor = Color.Red;
                    lblRes.Text = "You cannot deliver all your orders with the selected trucks.\n";
                    btnDeliver.Enabled = false;
                    foreach (KeyValuePair<int, int> entry in auxStores)
                    {
                        if(entry.Value > 0)
                            lblRes.Text += "Missing " + entry.Value + " " +getType(entry.Key) + "\n";
                    }
                }                    
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

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            foreach(Store store in stores)            
                store.products = null;

            for(int i = 0; i < stores.Count; i++)
            {
                if (stores[i].products == null)
                {
                    using (MakeOrder make = new MakeOrder(stores[i]))
                    {                        
                        var result = make.ShowDialog();
                        if (result == DialogResult.OK)
                            stores[i] = make.store;
                    }
                    stores[i].CalculateAmount();
                }                
            }
            this.Close();
        }
    }
}
