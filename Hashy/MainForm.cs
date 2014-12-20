using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Hashy {
	public partial class MainForm : Form {
		#region consts
		#endregion
		#region fields
		#region object fields
		private HashAlgorithm[] algorithms;
		#endregion
		#region static fields
		#endregion
		#endregion
		#region events
		#region object events
		#endregion
		#region static events
		#endregion
		#endregion
		#region properties
		#region object properties
		#endregion
		#region static properties
		#endregion
		#endregion
		#region event handlers
		#region object event handlers
		private void MainForm_Load(object sender, EventArgs e) {
			cbxAlgorithm.SelectedIndex = 0;
			txtSource.Focus();
		}
		private void btnGenerate_Click(object sender, EventArgs e) {
			var text = txtSource.Text.Trim();
			txtSource.Text = text;
			if (text.Length == 0) {
				lblTarget.Text = string.Empty;
				txtSource.Focus();
				return;
			}
			HashAlgorithm ha = algorithms[cbxAlgorithm.SelectedIndex];
			var source = Encoding.UTF8.GetBytes(txtSource.Text);
			var target = BitConverter.ToString(ha.ComputeHash(source)).Replace("-", "");
			if (chkToLower.Checked) target = target.ToLower();
			lblTarget.Text = target;
			txtSource.Focus();
		}
		private void cbxAlgorithm_SelectedIndexChanged(object sender, EventArgs e) {
			btnGenerate_Click(sender, e);
		}
		private void lblTarget_MouseDown(object sender, MouseEventArgs e) {
			Clipboard.SetText(lblTarget.Text);
			MessageBox.Show("Hash copied to clipboard.",
				"Information", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
		private void txtSource_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) txtSource.UseSystemPasswordChar = false;
		}
		private void txtSource_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) txtSource.UseSystemPasswordChar = true;
		}
		private void chkToLower_CheckedChanged(object sender, EventArgs e) {
			lblTarget.Text = chkToLower.Checked ? lblTarget.Text.ToLower() : lblTarget.Text.ToUpper();
			txtSource.Focus();
		}
		#endregion
		#region static event handlers
		#endregion
		#endregion
		#region constructors
		#region object constructors
		public MainForm() {
			InitializeComponent();
			algorithms = new HashAlgorithm[] {
				MD5.Create(), SHA1.Create(), SHA256.Create(), SHA512.Create()
			};
		}
		#endregion
		#region static constructors
		#endregion
		#endregion
		#region interfaces
		#endregion
		#region methods
		#region object methods
		#endregion
		#region static methods
		[STAThread]
		public static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		#endregion
		#endregion
	}
}