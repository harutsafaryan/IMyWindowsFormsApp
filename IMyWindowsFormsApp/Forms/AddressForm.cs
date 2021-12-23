using IMyWindowsApp.Data.Models;
using IMyWindowsApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMyWindowsFormsApp.Forms
{
    public partial class AddressForm : Form
    {
        private readonly IAddressService _addressService;
        private readonly _IAppCache _appCache;
        public AddressForm(IAddressService addressService, _IAppCache appCache)
        {
            InitializeComponent();

            _addressService = addressService;
            _appCache = appCache;
            _appCache._ViewBag.TryGetValue("studentId", out object studentId);
            _appCache._ViewBag.TryGetValue("studentName", out object studentName);
            lblGuid.Text = studentId?.ToString();
            lblFullName.Text = studentName?.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _appCache._ViewBag.TryGetValue("studentId", out object studentId);
            Address address = new Address
            {
                Adr = txtAddress.Text,
                StudentId = (Guid)studentId
            };

            _addressService.Add(address);

            RefreshAddresses();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdAddresses.SelectedRows.Count == 0)
                return;
            else
            {
                Address address = _addressService.Get((Guid)grdAddresses.SelectedRows[0].Cells[0].Value);
                _addressService.Remove(address);
                RefreshAddresses();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Address address = new Address()
            {
                Id = (Guid)(Guid)grdAddresses.SelectedRows[0].Cells["Id"].Value,
                StudentId = (Guid)grdAddresses.SelectedRows[0].Cells["StudentId"].Value,
                Adr = txtAddress.Text
            };
            _addressService.Update(address);
            RefreshAddresses();
        }

        private void grdAddresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRow();
        }

        private void ShowRow()
        {
            txtAddress.Text = grdAddresses.SelectedRows[0].Cells["Adr"].Value.ToString();
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            RefreshAddresses();
        }

        public void RefreshAddresses()
        {
            grdAddresses.ClearSelection();

            _appCache._ViewBag.TryGetValue("studentId", out object studentId);
            grdAddresses.DataSource = _addressService.GetAllByStudent((Guid)studentId).ToList();
            if (grdAddresses.Rows.Count > 0)
            {
                grdAddresses.Rows[0].Selected = true;
            }
        }

        
    }
}
